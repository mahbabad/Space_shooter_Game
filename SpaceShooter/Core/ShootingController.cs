using SpaceShooter.Models;
using SpaceShooter.Views;
using System.Collections.Generic;

namespace SpaceShooter.Core
{
    public class ShootingController
    {
        private float _playerFireCooldown = 0f;
        private GameSession _session;

        public ShootingController(GameSession session) 
        {
            _session = session;
        }

        public void UpdatePlayerShooting(PlayerShip player, InputState input, List<Bullet> activeBullets, float deltaTime)
        {
            if (_playerFireCooldown > 0)
            {
                _playerFireCooldown -= deltaTime;
            }

            if (input.IsShooting && _playerFireCooldown <= 0f)
            {
                if(_session.CurrentWave >= 5)
                {
                    trippleShoot(player, activeBullets);
                    _playerFireCooldown = GameRules.PlayerFireRate;
                }
                else
                {
                    Shoot(player, activeBullets);

                    _playerFireCooldown = GameRules.PlayerFireRate;
                }

            }
        }

        public void UpdateEnemyShooting(List<BaseEnemy> enemies, List<Bullet> activeBullets, float deltaTime)
        {
            List<Bullet> pendingBullets = new List<Bullet>();

            foreach (var enemy in enemies)
            {
                if (!enemy.IsActive) continue;

                var newBullets = enemy.UpdateShooting(deltaTime);
                if (newBullets.Count > 0)
                {
                    pendingBullets.AddRange(newBullets);
                }
            }

            if (pendingBullets.Count > 0)
            {
                activeBullets.AddRange(pendingBullets);
            }
        }



        private void Shoot(PlayerShip player, List<Bullet> activeBullets)
        {
            

            float spawnX = player.X + (player.Width / 2f) - ( GameRules.BulletWidth / 2f);
            float spawnY = player.Y;

            Bullet newBullet = new Bullet
            (
                 spawnX,
                 spawnY,
                 0f,
                 -GameRules.PlayerBulletSpeed,
                 player.BulletDamage,
                 true
            );
            AudioManager.PlaySfx(Properties.Resources.shot);


            activeBullets.Add(newBullet);
        }

        private void trippleShoot(PlayerShip player , List<Bullet> activeBullets)
        {
            float spawnX = player.X + (player.Width / 2f) - (GameRules.BulletWidth / 2f);
            float spawnY = player.Y;
            float zarib = 5;
            for (int i = 1; i<4 ; i++)
            {
             
                float angle = zarib * (float)(Math.PI /12 );

                Bullet newBullet = new Bullet
                    (
                        spawnX,
                        spawnY,
                        velocityX: GameRules.PlayerBulletSpeed * (float) Math.Cos(angle),
                        velocityY: -GameRules.PlayerBulletSpeed * (float)Math.Sin(angle),
                        damage : player.BulletDamage,
                        isPlayerBullet: true);

                activeBullets.Add(newBullet);
                zarib += 1f;
            }

            
        }
    }
}

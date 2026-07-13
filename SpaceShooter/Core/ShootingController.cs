using SpaceShooter.Models;
using SpaceShooter.Views;
using System.Collections.Generic;

namespace SpaceShooter.Core
{
    public class ShootingController
    {
        private float _playerFireCooldown = 0f;

        public void UpdatePlayerShooting(PlayerShip player, InputState input, List<Bullet> activeBullets, float deltaTime)
        {
            if (_playerFireCooldown > 0)
            {
                _playerFireCooldown -= deltaTime;
            }

            if (input.IsShooting && _playerFireCooldown <= 0f)
            {
                Shoot(player, activeBullets);

                _playerFireCooldown = GameRules.PlayerFireRate;
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

            AudioManager.PlaySfx(SpaceShooter.Properties.Resources.shot);
            activeBullets.Add(newBullet);
        }
    }
}

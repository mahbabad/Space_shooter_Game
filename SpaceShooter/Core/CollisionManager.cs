using SpaceShooter.Interfaces;
using SpaceShooter.Models;
using SpaceShooter.Views;
using System.Collections.Generic;

namespace SpaceShooter.Core
{
    public class CollisionManager
    {
        private readonly ScoreManager _scoreManager;
        private readonly CoinManager _coinManager;

        public CollisionManager(ScoreManager scoreManager, CoinManager coinManager)
        {
            _scoreManager = scoreManager;
            _coinManager = coinManager;
        }

        public void HandleAllCollisions(
            PlayerShip player,
            List<BaseEnemy> enemies,
            List<Bullet> activeBullets,
            List<Coin> coins,
            List<ExplosionEffect> ExplosionFx,
            List<Shield> shields)
        {
            if (player == null || player.Health <= 0) return;

            HandleBulletCollisions(player, enemies, activeBullets, coins , ExplosionFx, shields);
            HandlePlayerEnemyCollisions(player, enemies , ExplosionFx);
            HandleCoinCollections(player, coins);
            HandleBulletBulletCollision(activeBullets);
            HandleShieldCollections(player, shields);
        }

        private void HandleBulletCollisions(PlayerShip player, List<BaseEnemy> enemies, List<Bullet> activeBullets, List<Coin> coins , List<ExplosionEffect> ExplosionFx, List<Shield> shields)
        {
            for (int i = activeBullets.Count - 1; i >= 0; i--)
            {
                Bullet bullet = activeBullets[i];

                if (!bullet.IsActive) continue;

                if (bullet.IsPlayerBullet)
                {
                    for (int j = enemies.Count - 1; j >= 0; j--)
                    {
                        BaseEnemy enemy = enemies[j];

                        if (!enemy.IsActive) continue;

                        if (CheckCollision(bullet, enemy))  
                        {
                            enemy.TakeDamage(bullet.Damage);

                            if (enemy.Health <= 0)
                            {
                                ExplosionEffect fx = new ExplosionEffect(enemy.X , enemy.Y , enemy.Width , enemy.Height);
                                AudioManager.PlayBoombMusic(Properties.Resources.bomb, "boomb.wav");
                                ExplosionFx.Add(fx);
                            
                                enemy.IsActive = false;
                                _scoreManager.AddScore(enemy.ScoreValue);

                                Random rand = new Random();
                                bool flag = false;
                                


                                var droppedCoins = _coinManager.CheckAndDropCoins(enemy);
                                if (droppedCoins != null && droppedCoins.Count > 0)
                                {
                                    coins.AddRange(droppedCoins);
                                    flag = true;
                                }

                                var droppedShield = enemy.TryDropShield(rand);
                                if (droppedShield != null && !flag)
                                {
                                    shields.Add(droppedShield);
                                    
                                }

                            }

                            bullet.IsActive = false;
                            break;             
                        }
                    }
                }
                else
                {
                    if (CheckCollision(bullet, player))
                    {
                        player.TakeDamage(bullet.Damage);
                        bullet.IsActive = false;       
                    }
                }
            }
        }

        private void HandlePlayerEnemyCollisions(PlayerShip player, List<BaseEnemy> enemies , List<ExplosionEffect> ExplosionFx)
        {
            for (int i = enemies.Count - 1; i >= 0; i--)
            {
                BaseEnemy enemy = enemies[i];
                if (!enemy.IsActive) continue;

                if (CheckCollision(player, enemy))
                {
                    player.TakeDamage(1);
                    enemy.TakeDamage(25);

                    if (enemy.Health <= 0)
                    {
                        ExplosionEffect fx = new ExplosionEffect(enemy.X, enemy.Y, enemy.Width, enemy.Height);
                        AudioManager.PlayBoombMusic(Properties.Resources.bomb, "boomb.wav");
                        ExplosionFx.Add(fx);
                        enemy.IsActive = false;   
                    }
                }
            }
        }

        private void HandleCoinCollections(PlayerShip player, List<Coin> coins)
        {
            for (int i = coins.Count - 1; i >= 0; i--)
            {
                Coin coin = coins[i];
                if (!coin.IsActive) continue;

                if (CheckCollision(player, coin))
                {
                    AudioManager.CoinPlayer(Properties.Resources.CoinMusic, "coin.wav");
                    _coinManager.CollectCoin(coin);

                }
            }
        }

        private void HandleShieldCollections(PlayerShip player, List<Shield> shields)
        {
            for (int i = shields.Count - 1; i >= 0; i--)
            {
                Shield shield = shields[i];

                if (!shield.IsActive)
                    continue;

                if (CheckCollision(player, shield))
                {
                    player.ShieldDuration = 5f;
                    shield.Collect();
                }
            }
        }
        private void HandleBulletBulletCollision(List<Bullet> activeBullets)
        {
            for(int i =activeBullets.Count-1; i>=0; i--)
            {
                var bullet = activeBullets[i];

                if(!bullet.IsActive) continue;
                if (bullet.IsPlayerBullet)
                {
                    for(int j = activeBullets.Count-1 ; j>= 0 ; j--)
                    {
                        var enemyBullet = activeBullets[j];
                        if (!enemyBullet.IsActive) continue;
                        if (enemyBullet.IsPlayerBullet) continue;

                     
                        if( CheckCollision(bullet, enemyBullet))
                        {
                            bullet.IsActive = false;
                            enemyBullet.IsActive = false;
                            break;
                        }
                    }
                }
            }
        }

        private bool CheckCollision(BaseEntity entityA, BaseEntity entityB)
        {
            return entityA.GetCollisionBounds().IntersectsWith(entityB.GetCollisionBounds());
        }
    }
}

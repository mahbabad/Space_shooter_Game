using System.Collections.Generic;
using SpaceShooter.Models;
using SpaceShooter.Interfaces;

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
            List<Coin> coins)
        {
            if (player == null || player.Health <= 0) return;

            HandleBulletCollisions(player, enemies, activeBullets, coins);
            HandlePlayerEnemyCollisions(player, enemies, coins);
            HandleCoinCollections(player, coins);
        }

        private void HandleBulletCollisions(PlayerShip player, List<BaseEnemy> enemies, List<Bullet> activeBullets, List<Coin> coins)
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
                                enemy.IsActive = false;
                                _scoreManager.AddScore(enemy.ScoreValue);

                                var droppedCoins = _coinManager.CheckAndDropCoins(enemy);
                                if (droppedCoins != null && droppedCoins.Count > 0)
                                {
                                    coins.AddRange(droppedCoins);
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

        private void HandlePlayerEnemyCollisions(PlayerShip player, List<BaseEnemy> enemies, List<Coin> coins)
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
                        enemy.IsActive = false;   

                        if (player.Health > 0)
                        {
                            _scoreManager.AddScore(enemy.ScoreValue);

                            var droppedCoins = _coinManager.CheckAndDropCoins(enemy);
                            if (droppedCoins != null && droppedCoins.Count > 0)
                            {
                                coins.AddRange(droppedCoins);
                            }
                        }
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
                    _coinManager.CollectCoin(coin);

                }
            }
        }

        private bool CheckCollision(BaseEntity entityA, BaseEntity entityB)
        {
            return entityA.GetCollisionBounds().IntersectsWith(entityB.GetCollisionBounds());
        }
    }
}

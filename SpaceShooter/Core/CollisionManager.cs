using System.Collections.Generic;
using SpaceShooter.Models;
using SpaceShooter.Interfaces;

namespace SpaceShooter.Core
{
    public class CollisionManager
    {
        public void HandleAllCollisions(
            PlayerShip player,
            List<BaseEnemy> enemies,
            List<Bullet> activeBullets,
            List<Coin> coins)
        {
            if (player == null || player.Health <= 0) return;

            HandleBulletCollisions(player, enemies, activeBullets);
            HandlePlayerEnemyCollisions(player, enemies);
            HandleCoinCollections(player, coins);
        }

        
        private void HandleBulletCollisions(PlayerShip player, List<BaseEnemy> enemies, List<Bullet> activeBullets)
        {
            for (int i = activeBullets.Count - 1; i >= 0; i--)
            {
                Bullet bullet = activeBullets[i];

                if (bullet.IsPlayerBullet)
                {
                   
                    for (int j = enemies.Count - 1; j >= 0; j--)
                    {
                        BaseEnemy enemy = enemies[j];
                        if (CheckCollision(bullet, enemy))
                        {
                            enemy.TakeDamage(bullet.Damage); 
                            activeBullets.RemoveAt(i);      
                            break;
                        }
                    }
                }
                else
                {
                    if (CheckCollision(bullet, player))
                    {
                        player.TakeDamage(bullet.Damage);     
                        activeBullets.RemoveAt(i);          
                    }
                }
            }
        }

      
        private void HandlePlayerEnemyCollisions(PlayerShip player, List<BaseEnemy> enemies)
        {
            for (int i = enemies.Count - 1; i >= 0; i--)
            {
                BaseEnemy enemy = enemies[i];
                if (CheckCollision(player, enemy))
                {
                    player.TakeDamage(1); 
                    enemy.TakeDamage(25); 
                }
            }
        }

        
        private void HandleCoinCollections(PlayerShip player, List<Coin> coins)
        {
            for (int i = coins.Count - 1; i >= 0; i--)
            {
                Coin coin = coins[i];
                if (CheckCollision(player, coin))
                {
                    coins.RemoveAt(i); 
                }
            }
        }

        private bool CheckCollision(BaseEntity entityA, BaseEntity entityB)
        {
           return entityA.GetBounds().IntersectsWith(entityB.GetBounds());
        }
    }
}

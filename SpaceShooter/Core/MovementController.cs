using SpaceShooter.Models;
using System.Drawing;
using System.Numerics;

namespace SpaceShooter.Core
{
    public class MovementController
    {
        public void UpdatePlayer(PlayerShip player, InputState input,
                                 RectangleF gameArea, float deltaTime)
        {
            int dx = 0;
            int dy = 0;

            if (input.IsMovingLeft) dx -= 1;
            if (input.IsMovingRight) dx += 1;
            if (input.IsMovingUp) dy -= 1;
            if (input.IsMovingDown) dy += 1;

            player.VelocityX = dx * player.Speed ;
            player.VelocityY = dy * player.Speed;

            player.UpdateMovement(deltaTime);
            ClampToBounds(player, gameArea);
        }

        public void UpdateEnemies(List<BaseEnemy> enemies, RectangleF gameArea, float deltaTime , PlayerShip player)
        {
            foreach (var enemy in enemies)
            {
                if (!enemy.IsActive) continue;

                if (enemy is TeroristEnemy terorist)
                {
                    terorist.SetTarget(
                    player.X + player.Width / 2 - terorist.Width / 2
                    ,player.Y);
                }

                enemy.UpdateMovement(deltaTime);

                if (enemy.Y > gameArea.Bottom)
                    enemy.IsActive = false;
            }
        }

        public void UpdateBullets(List<Bullet> bullets, RectangleF gameArea, float deltaTime)
        {
            foreach (var bullet in bullets)
            {
                if (!bullet.IsActive) continue;

                bullet.UpdateMovement(deltaTime);

                if (bullet.Y + bullet.Height < gameArea.Top ||       
                    bullet.Y > gameArea.Bottom ||                  
                    bullet.X + bullet.Width < gameArea.Left ||    
                    bullet.X > gameArea.Right)                        
                {
                    bullet.IsActive = false;
                }
            }
        }

        public void UpdateCoins(List<Coin> coins , RectangleF gameArea, float deltaTime)
        {
            foreach(var coin in coins)
            {
                coin.UpdateMovement(deltaTime);


                if (coin.Y > gameArea.Bottom)
                    coin.IsActive = false;
            }
        }

        public void UpdateShields(List<Shield> shields, RectangleF gameArea, float deltaTime)
        {
            foreach (var shield in shields)
            {
                if (!shield.IsActive)
                    continue;

                shield.UpdateMovement(deltaTime);

                if (shield.Y > gameArea.Bottom)
                    shield.IsActive = false;
            }
        }
        private void ClampToBounds(PlayerShip player, RectangleF gameArea)
        {
            if (player.X < gameArea.Left)
                player.X = gameArea.Left;

            if (player.X + player.Width > gameArea.Right)
                player.X = gameArea.Right - player.Width;

            if (player.Y < gameArea.Top)
                player.Y = gameArea.Top;

            if (player.Y + player.Height > gameArea.Bottom)
                player.Y = gameArea.Bottom - player.Height;
        }
    }
}

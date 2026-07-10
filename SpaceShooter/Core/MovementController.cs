using System.Drawing;
using SpaceShooter.Models;

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

            player.VelocityX = dx *GameRules.PlayerMoveSpeed ;
            player.VelocityY = dy * GameRules.PlayerMoveSpeed;

            player.UpdateMovement(deltaTime);
            ClampToBounds(player, gameArea);
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

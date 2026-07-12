using SpaceShooter.Interfaces;
using SpaceShooter.Core;

namespace SpaceShooter.Models
{
    public class Bullet : BaseEntity
    {
        public int Damage { get; set; }

        public bool IsPlayerBullet { get; set; }

        public bool IsHeavyTankBullet { get; set; }

        public Bullet(float x, float y, float velocityX, float velocityY,
                      int damage, bool isPlayerBullet , bool isHeavyTank =false ):base(x, y , Core.GameRules.BulletWidth , Core.GameRules.BulletHeight)
        {
            VelocityX = velocityX;  
            VelocityY = velocityY;
            Damage = damage;
            IsPlayerBullet = isPlayerBullet;
            IsHeavyTankBullet = isHeavyTank;

            if (IsHeavyTankBullet) { Width = 50f; Height = 50f; }
        }
    }
}

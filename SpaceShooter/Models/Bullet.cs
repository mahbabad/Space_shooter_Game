using SpaceShooter.Interfaces;
using SpaceShooter.Core;

namespace SpaceShooter.Models
{
    public class Bullet : BaseEntity
    {
        public int Damage { get; set; }

        public bool IsPlayerBullet { get; set; }

        public Bullet(float x, float y, float velocityX, float velocityY,
                      int damage, bool isPlayerBullet):base(x, y , Core.GameRules.BulletWidth , Core.GameRules.BulletHeight)
        {
            VelocityX = velocityX;  
            VelocityY = velocityY;
            Damage = damage;
            IsPlayerBullet = isPlayerBullet;
        }
    }
}

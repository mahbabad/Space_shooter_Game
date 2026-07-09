using SpaceShooter.Interfaces;

namespace SpaceShooter.Models
{
    public class Bullet : BaseEntity
    {
        public int Damage { get;}

        public bool IsPlayerBullet { get; }

        public Bullet(float x, float y, float velocityX, float velocityY,
                      int damage, bool isPlayerBullet):base(x, y , 4f , 12f)
        {
            VelocityX = velocityX;  
            VelocityY = velocityY;
            Damage = damage;
            IsPlayerBullet = isPlayerBullet;
        }
    }
}

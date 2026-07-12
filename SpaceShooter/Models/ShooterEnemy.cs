using SpaceShooter.Core;
using SpaceShooter.Enums;
using System;
using System.Collections.Generic;


namespace SpaceShooter.Models
{
    public class ShooterEnemy : BaseEnemy
    {
        private const float ShootInterval = 3f; 
        private const float BulletSpeed = 200f;
        private const int BulletDamage = 1;
        private float _timeSinceLastShot;

        public ShooterEnemy(float x, float y)
            : base
            (x, y,
             width:GameRules.EnemyWidth, height: GameRules.EnemyHeigth,
              maxHealth: 50,
             scoreValue: 50,
             coinDropChance: 0.55f,
             goldCoinChance : 0.35f)
        {
            VelocityY = 60f;
            VelocityX = 60f;
        }

      

        public override List<Bullet> UpdateShooting(float deltaTime)
        {
            var bullets = new List<Bullet>();
            _timeSinceLastShot += deltaTime;

            if (_timeSinceLastShot >= ShootInterval)
            {
                _timeSinceLastShot = 0f;
                bullets.Add(new Bullet(
                    x: X + Width / 2,
                    y: Y + Height,
                    velocityX: 0f,
                    velocityY: BulletSpeed,
                    damage:BulletDamage,
                    isPlayerBullet : false));
            }
            return bullets;
        }
    }
}

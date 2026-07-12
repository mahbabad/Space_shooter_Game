using SpaceShooter.Core;
using SpaceShooter.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceShooter.Models
{
    public class HeavyTankEnemy : BaseEnemy
    {
        private const float ShootInterval = 3f;     
        private const float BulletSpeed = 200f;     
        private float _timeSinceLastShot;

        public HeavyTankEnemy(float x, float y)
            : base(x, y,
                   width:GameRules.HeavyTankScale , height:GameRules.HeavyTankScale ,
                   maxHealth: 200,
                   scoreValue: 150,
                   coinDropChance: 0.90f,
                   goldCoinChance : 0.80f)
        {
            VelocityY = 30f;
            VelocityX = 30f;
        }


        private const int BulletDamage = 4;

        public override List<Bullet> UpdateShooting(float deltaTime)
        {
            var bullets = new List<Bullet>();
            _timeSinceLastShot += deltaTime;

            if (_timeSinceLastShot >= ShootInterval)
            {
                _timeSinceLastShot = 0f;

                float centerX = X + Width / 3;
                float centerY = Y + Height / 2;

                for (int i = 0; i < 8; i++)
                {
                    float angle = i * (float)(Math.PI / 8);
                    bullets.Add(new Bullet(
                        x: centerX,
                        y: centerY,
                        velocityX: BulletSpeed * (float)Math.Cos(angle),
                        velocityY: BulletSpeed * (float)Math.Sin(angle),
                        damage: BulletDamage,
                        isPlayerBullet: false,
                        isHeavyTank : true
                        ));
             
                }
            }
            return bullets;
        }




    }
}

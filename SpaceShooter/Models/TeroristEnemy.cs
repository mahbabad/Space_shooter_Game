using System;
using System.Collections.Generic;

namespace SpaceShooter.Models
{
    public class TeroristEnemy : BaseEnemy
    {
        private const float ChaseSpeed = 200f;        
        public const int ExplosionDamage = 35;          

        private float _targetX;
        private float _targetY;

        public TeroristEnemy(float x, float y)
        :base(x, y,
                width:40f,
                height:40f,
                maxHealth: 30,
                scoreValue : 100,
                coinDropChance: 0.50f,
                goldCoinChance:0.30f
                )
        {
            VelocityY = ChaseSpeed;  
        }


        public void SetTarget(float targetX, float targetY)
        {
            _targetX = targetX;
            _targetY = targetY;
        }

        protected override void DefaultMovement(float deltaTime)
        {
            float dx = _targetX - X;
            float dy = _targetY - Y;
            float distance = (float)Math.Sqrt(dx * dx + dy * dy);

            if (distance > 1f)
            {
                X += (dx / distance) * ChaseSpeed * deltaTime;
                Y += (dy / distance) * ChaseSpeed * deltaTime;
            }
            else
            {
                Y += ChaseSpeed * deltaTime;
            }
        }
     }
}



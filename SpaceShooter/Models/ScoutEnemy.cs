using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceShooter.Models
{
    public class ScoutEnemy : BaseEnemy
    {
        private readonly float _baseX;       
        private float _elapsedTime;

        private const float Amplitude = 60f;    
        private const float Frequency = 3f;

        public ScoutEnemy(float x , float y) : base(x, y,
            width : 70 , height : 70,
            maxHealth: 20 , scoreValue : 25 , 
            coinDropChance:0.40f , goldCoinChance : 0.20f)
        {
            _baseX = x;
            VelocityY = 130f;
             
        }

        public override void UpdateMovement(float deltaTime)
        {
            _elapsedTime += deltaTime;  
            X = _baseX + Amplitude * (float)Math.Sin(Frequency * _elapsedTime);
            Y += VelocityY * deltaTime;
        }

    }
}

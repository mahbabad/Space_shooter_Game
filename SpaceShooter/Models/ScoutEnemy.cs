using SpaceShooter.Core;
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
        private const float InformationAmplitude = 20f;
        private const float Frequency = 3f;
        private bool _wasinFormayion;

        public ScoutEnemy(float x , float y) : base(x, y,
            width : GameRules.EnemyWidth , height : GameRules.EnemyWidth,
            maxHealth: 20 , scoreValue : 25 , 
            coinDropChance:0.40f , goldCoinChance : 0.20f)
        {
            _baseX = x;
            VelocityY = 130f;
            VelocityX = 130f;
        }

        protected override void DefaultMovement(float deltaTime)
        {
            _elapsedTime += deltaTime;
            X = _baseX + Amplitude * (float)Math.Sin(Frequency * _elapsedTime);
            Y += VelocityY * deltaTime;
        }

        protected override void UpdateInFormation(float deltaTime)
        {
            if (!_wasinFormayion)
            {
                _elapsedTime = 0f;      
                _wasinFormayion = true;
            }

            _elapsedTime += deltaTime;
            X = formationAnchorX + InformationAmplitude * (float)Math.Sin(Frequency * _elapsedTime);
        }
    }



}


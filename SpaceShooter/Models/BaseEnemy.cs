using Microsoft.VisualBasic;
using SpaceShooter.Enums;
using SpaceShooter.Interfaces;
using System.Collections.Generic;

namespace SpaceShooter.Models
{
    public abstract class BaseEnemy : BaseEntity, IDamagble
    {
        public int Health { get;  set; }
        public int MaxHealth { get;}
        public bool IsDestroyed { get { return Health <= 0; } }  
        public PointF? FormationTarget { get; set; }=null;
        public bool  IsInFormation { get; set; } = false;
        public float formationAnchorX { get; set; }
            
            

        public int ScoreValue { get; protected set; }

        public float CoinDropChance { get; protected set; }

        public float GoldCoinChance { get; protected set; }

        protected BaseEnemy(float x, float y, float width, float height,
                            int maxHealth, int scoreValue,
                            float coinDropChance, float goldCoinChance)
            : base(x, y, width, height)
        {
            MaxHealth = maxHealth;
            Health = maxHealth;
            ScoreValue = scoreValue;
            CoinDropChance = coinDropChance;
            GoldCoinChance = goldCoinChance;
        }

        public virtual void TakeDamage(int amount)
        {
            if (IsDestroyed) return;
            Health -= amount;
            if (Health <= 0)
            {
                Health = 0;
                IsActive = false;
            }
        }

        
        public virtual Coin? TryDropCoin(Random random)
        {
            if (random.NextDouble() > CoinDropChance)
                return null;

            var type = random.NextDouble() < GoldCoinChance ? CoinType.Gold : CoinType.Silver;
            return new Coin(X + Width / 2f, Y + Height / 2f, type);
        }

        public virtual void UpdateMovement(float deltaTime)
        {
            if (FormationTarget.HasValue && !IsInFormation)
            {
                MoveTowardsFormation(deltaTime);
            }
            else if (IsInFormation)
            {
                UpdateInFormation(deltaTime);  
            }
            else
            {
                DefaultMovement(deltaTime);    
            }
        }

        protected virtual void DefaultMovement(float deltaTime)
        {
            Y += VelocityY * deltaTime;
        }
        protected virtual void UpdateInFormation(float deltaTime)
        {

        }

        protected virtual void MoveTowardsFormation(float deltaTime)
        {
            var t = FormationTarget.Value;
            float dx = t.X - X;
            float dy = t.Y - Y;
            float dist = (float)Math.Sqrt(dx * dx + dy * dy);

            if (dist < 5f)
            {
                X = t.X; Y = t.Y;
                VelocityX = 0; VelocityY = 0;
                IsInFormation = true;
                return;
            }
            X += (dx / dist) * VelocityX * deltaTime;
            Y += (dy / dist) * VelocityY * deltaTime;
        }

        public virtual List<Bullet> UpdateShooting(float deltaTime)
        {
            return new List<Bullet>();
        }
    }
}

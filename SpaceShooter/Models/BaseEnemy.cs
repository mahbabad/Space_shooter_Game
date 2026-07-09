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
            Y += VelocityY * deltaTime;
        }

        public virtual List<Bullet> UpdateShooting(float deltaTime)
        {
            return new List<Bullet>();
        }
    }
}

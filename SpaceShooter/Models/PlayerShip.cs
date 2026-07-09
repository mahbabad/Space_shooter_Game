using System;
using SpaceShooter.Interfaces;

namespace SpaceShooter.Models
{
    public class PlayerShip : BaseEntity, IDamagble
    {
        private readonly ShipInfo _info;

        public int Health { get; set; }
        public int MaxHealth { get; }
        public bool IsDestroyed => Health <= 0;

        public float Speed => _info.Speed;
        public string Name => _info.Name;
        public int ShipId => _info.Id;

        public PlayerShip(ShipInfo info, float startX, float startY,
                          float width = 50f, float height = 50f)
            : base(startX, startY, width, height)
        {
            _info = info ?? throw new ArgumentNullException(nameof(info));

            if (info.MaxHealth <= 0)
                throw new ArgumentException("MaxHealth Must be positive.", nameof(info));

            MaxHealth = info.MaxHealth;
            Health = info.MaxHealth;
        }

   
        public void SetDirection(float dirX, float dirY)
        {
            float length = (float)Math.Sqrt(dirX * dirX + dirY * dirY);
            if (length > 0f)
            {
                dirX /= length;
                dirY /= length;
            }

            VelocityX = dirX * Speed;
            VelocityY = dirY * Speed;
        }

        public override void UpdateMovement(float deltaTime)
        {
            X += VelocityX * deltaTime;
            Y += VelocityY * deltaTime;
        }

        public void TakeDamage(int amount)
        {
            if (amount <= 0 || IsDestroyed)
                return;

            Health -= amount;
            if (Health < 0)
                Health = 0;
        }
    }
}

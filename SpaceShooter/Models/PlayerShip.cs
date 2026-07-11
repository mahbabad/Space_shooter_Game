using System;
using SpaceShooter.Interfaces;
using SpaceShooter.Core;

namespace SpaceShooter.Models
{
    public class PlayerShip : BaseEntity, IDamagble
    {
        public int Health { get;  set; }
        public int MaxHealth { get; }
        public bool IsDestroyed { get { return Health <= 0; } }

        public PlayerShip(float startX, float startY,
                          float width = 100f, float height = 100f)
            : base(startX, startY, width, height)
        {
            MaxHealth = Core.GameRules.PlayerMaxHealth;
            Health = Core.GameRules.PlayerMaxHealth;
        }

        public void TakeDamage(int amount)
        {
            if (amount < 0)
                return;

            Health -= amount;
        }
    }
}

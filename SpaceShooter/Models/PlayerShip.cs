using System;
using SpaceShooter.Interfaces;
using SpaceShooter.Core;

namespace SpaceShooter.Models
{
    public class PlayerShip : BaseEntity, IDamagble
    {
        public int Health { get;  set; }
        public int MaxHealth { get; }
        public float Speed { get; set; }          
        public int BulletDamage { get; set; }
        public bool IsDestroyed { get { return Health <= 0; } }
        public float ShieldDuration { get; set; } = 0f;
        public bool IsShielded => ShieldDuration > 0f;
        public PlayerShip(float startX, float startY,
                          float width = 100f, float height = 100f)
            : base(startX, startY, width, height)
        {
            MaxHealth = Core.GameRules.PlayerMaxHealth;
            Health = Core.GameRules.PlayerMaxHealth;
            Speed = Core.GameRules.PlayerMoveSpeed;       
            BulletDamage = Core.GameRules.PlayerBulletDamage;
        }

        public void TakeDamage(int amount)
        {
            if (amount < 0)
                return;
            if (IsShielded)
                return;
            Health -= amount;
        }
    }
}

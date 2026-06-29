using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceShooter.Interfaces
{
    public interface IDamagble
    {
        public int Health { get; set; }
        public int MaxHealth { get; }
        public bool IsDestroyed { get; }

        public void TakeDamage(int amount);
    }
}

using SpaceShooter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceShooter.Models
{
    public class Shield : BaseEntity, ICollectible
    {
        public bool IsCollected { get; private set; }
        public Shield(float x, float y) : base(x, y, 50f, 50f)
        {
            VelocityX = 0f;
            VelocityY = 100f;
        }

        public void Collect()
        {
            IsCollected = true;
            IsActive = false;
        }
    }
}

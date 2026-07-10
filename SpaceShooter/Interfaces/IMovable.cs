using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceShooter.Interfaces
{
    public interface IMovable
    {
        public float X {  get; set; }
        public float Y { get; set; }
        public float VelocityX { get; set; }
        public float VelocityY { get; set; }

        public void UpdateMovement(float deltaTime);
    }
}

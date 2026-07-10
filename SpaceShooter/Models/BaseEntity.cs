using System;
using System.Drawing;
using SpaceShooter.Interfaces;

namespace SpaceShooter.Models
{
    public abstract class BaseEntity : IMovable
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float VelocityX { get; set; }
        public float VelocityY { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public bool IsActive { get; set; } = true;

        protected BaseEntity(float x, float y, float width, float height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

       
        public virtual void UpdateMovement(float deltaTime)
        {
            X += VelocityX * deltaTime;
            Y += VelocityY * deltaTime;
        }


        public RectangleF GetBounds()
        {
            return new RectangleF(X, Y, Width, Height);
        }
    }
}

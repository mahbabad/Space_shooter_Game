using SpaceShooter.Interfaces;

namespace SpaceShooter.Models
{
    public class Coin : BaseEntity, ICollectible
    {
        public const int Value = 1;

        public bool IsCollected { get; private set; }

        public Coin(float x, float y ):base(x , y, 16f , 16f) 
        {
            VelocityX = 0f;
            VelocityY = 60f;
        }

        public void Collect()
        {
            IsCollected = true;
            IsActive = false;
        }
    }
}

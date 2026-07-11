using SpaceShooter.Enums;

using SpaceShooter.Interfaces;

namespace SpaceShooter.Models
{
    public class Coin : BaseEntity, ICollectible
    {
        public CoinType type;

        public int value => type == CoinType.Gold ? 5 : 1;

        public bool IsCollected { get; private set; }

        public Coin(float x, float y ,CoinType type ):base(x , y, 60f , 60f) 
        {
            VelocityX = 0f;
            VelocityY = 60f;
            this.type = type; 
        }

        public void Collect()
        {
            IsCollected = true;
            IsActive = false;
        }
    }
}

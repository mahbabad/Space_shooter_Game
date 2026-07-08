namespace SpaceShooter.Models
{
    public class StandardEnemy : BaseEnemy
    {
        public StandardEnemy(float x, float y)
            : base(x, y, width: 32, height: 32,
                   maxHealth: 20,           
                   scoreValue: 10,         
                   coinDropChance: 0.30f,
                   goldCoinChance: 0.10f)
        {
            VelocityY = 80f; 
        }

        public override void UpdateMovement(float deltaTime)
        {
            Y += VelocityY * deltaTime;
        }
    }
}

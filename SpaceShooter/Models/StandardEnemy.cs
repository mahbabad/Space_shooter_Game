using SpaceShooter.Core;

namespace SpaceShooter.Models
{
    public class StandardEnemy : BaseEnemy
    {
        public StandardEnemy(float x, float y)
            : base(x, y, width: GameRules.EnemyWidth, height: GameRules.EnemyWidth,
                   maxHealth: 20,           
                   scoreValue: 10,         
                   coinDropChance: 0.30f,
                   goldCoinChance: 0.10f)
        {
            VelocityY = 80f;
            VelocityX = 80f;
        }

       
    }
}

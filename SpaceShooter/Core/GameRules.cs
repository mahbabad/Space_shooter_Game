using System;

namespace SpaceShooter.Core
{
    public static class GameRules
    {
        public const float PlayerMoveSpeed = 300f;
        public const int PlayerMaxHealth = 12;

        public const float PlayerBulletSpeed = 500f;
        public const int PlayerBulletDamage = 10;
        public const float PlayerFireRate = 0.35f;

        public const float BulletWidth = 40f;
        public const float BulletHeight = 40f;

        public const float BulletWidthEnemy = 10f;
        public const float BulletHeightEnemy = 10f;

        public const float EnemyWidth = 50f;
        public const float EnemyHeigth = 50f;


        public const float HeavyTankScale = 200f;
        

        public const float MIN_SPAWN_COOLDOWN = 0.4f;
        public const float BASE_SPAWN_COOLDOWN = 2.5f;
        public const int BOSS_WAVE = 10;
    }
}

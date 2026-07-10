using System;
using System.Collections.Generic;
using System.Drawing; 
using SpaceShooter.Models;

namespace SpaceShooter.Core
{
    public class EnemySpawner
    {
        private const float MIN_SPAWN_COOLDOWN = 0.4f;
        private const float BASE_SPAWN_COOLDOWN = 2.5f;

        private Random _random;
        private float _spawnCooldown;
        private float _timeSinceLastSpawn;

        public int CurrentWave { get; private set; }
        private int _enemiesSpawnedInCurrentWave;
        private int _totalEnemiesToSpawnForWave;

        
        private RectangleF _gameArea;

        public EnemySpawner(RectangleF gameArea)
        {
            _random = new Random();
            _gameArea = gameArea;
            CurrentWave = 1;

            StartNewWave();
        }

        public void UpdateGameArea(RectangleF newGameArea)
        {
            _gameArea = newGameArea;
        }

        public void Update(float deltaTime, List<BaseEnemy> activeEnemies, List<BaseEnemy> newlySpawnedEnemies)
        {
            _timeSinceLastSpawn += deltaTime;

            if (_enemiesSpawnedInCurrentWave < _totalEnemiesToSpawnForWave)
            {
                if (_timeSinceLastSpawn >= _spawnCooldown)
                {
                    SpawnEnemy(newlySpawnedEnemies);
                    _timeSinceLastSpawn = 0f;
                    _enemiesSpawnedInCurrentWave++;
                }
            }
            else if (activeEnemies.Count == 0 && newlySpawnedEnemies.Count == 0)
            {
                CurrentWave++;
                StartNewWave();
            }
        }

        private void StartNewWave()
        {
            _enemiesSpawnedInCurrentWave = 0;
            _timeSinceLastSpawn = 0f;

            _totalEnemiesToSpawnForWave = 5 + (int)(CurrentWave * 2.5f);

            _spawnCooldown = Math.Max(
                MIN_SPAWN_COOLDOWN,
                BASE_SPAWN_COOLDOWN * (float)Math.Pow(0.85, CurrentWave)
            );
        }

        private void SpawnEnemy(List<BaseEnemy> newlySpawnedEnemies)
        {
            BaseEnemy newEnemy = CreateRandomEnemyForCurrentWave();

            float spawnX = _gameArea.X + (float)_random.NextDouble() * (_gameArea.Width - newEnemy.Width);

            float spawnY = _gameArea.Y - 50f;

            newEnemy.X = spawnX;
            newEnemy.Y = spawnY;
            newEnemy.Health = newEnemy.Health + (2 * CurrentWave);
            newEnemy.VelocityY = newEnemy.VelocityY * (1f + 0.1f * CurrentWave);
        }

        private BaseEnemy CreateRandomEnemyForCurrentWave()
        {
                BaseEnemy newEnemy;
            int enemyTypeRate = _random.Next(100);

            if (CurrentWave >= 5 && enemyTypeRate< 15)
                newEnemy = new HeavyTankEnemy(0f, 0f);
            else if (CurrentWave >= 3 && enemyTypeRate< 40)
                newEnemy = new ShooterEnemy(0f, 0f);
            else if (CurrentWave >= 2 && enemyTypeRate< 70)
                newEnemy = new ScoutEnemy(0f, 0f);
            else
                newEnemy = new StandardEnemy(0f, 0f);

            return newEnemy;
        }
    
    }
}

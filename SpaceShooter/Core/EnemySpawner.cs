using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using SpaceShooter.Models;

namespace SpaceShooter.Core
{
    public class EnemySpawner
    {
       

        private Random _random;
        private float _spawnCooldown;
        private float _timeSinceLastSpawn;

        public int CurrentWave { get; private set; }
        private int _enemiesSpawnedInCurrentWave;
        private int _totalEnemiesToSpawnForWave;

        private List<PointF> _formationSlots;
        private int _nextSlotIndex;


        private RectangleF _gameArea;
        private GameSession _session;

        public EnemySpawner(RectangleF gameArea  , GameSession S)
        {
            _random = new Random();
            _gameArea = gameArea;
            _session = S;
            CurrentWave = 1;

            _session.CurrentWave = this.CurrentWave;


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
                _session.CurrentWave = this.CurrentWave;
                StartNewWave();
            }
        }

        private void StartNewWave()
        {
            _enemiesSpawnedInCurrentWave = 0;
            _timeSinceLastSpawn = 0f;
            _nextSlotIndex = 0;

            if (CurrentWave == GameRules.BOSS_WAVE)
            {
                _formationSlots = new List<PointF>
        {
            new PointF(_gameArea.X + _gameArea.Width / 2f,
                       _gameArea.Y + _gameArea.Height / 2f)};
                _totalEnemiesToSpawnForWave = 1;
                _spawnCooldown = GameRules.MIN_SPAWN_COOLDOWN;
                return;
            }

            int rows = Math.Min(2 + CurrentWave / 3, 4);
            int cols = 6;

            _formationSlots = FormationManager.GenerateFormation(_gameArea, 50f, rows, cols, 200f, 48f, 48f);

            _totalEnemiesToSpawnForWave = _formationSlots.Count;

            _spawnCooldown = Math.Max(
                GameRules.MIN_SPAWN_COOLDOWN,
                GameRules.BASE_SPAWN_COOLDOWN * (float)Math.Pow(0.85, CurrentWave)
            );

            
        }

        private void SpawnEnemy(List<BaseEnemy> newlySpawnedEnemies)
        {
            BaseEnemy newEnemy = CreateRandomEnemyForCurrentWave();

            float spawnX = _gameArea.X + (float)_random.NextDouble() * (_gameArea.Width - newEnemy.Width);

            float spawnY = _gameArea.Y - 50f;

            if (newEnemy is ScoutEnemy sc)
            {
                spawnX = _gameArea.X + 50f;
            }

            newEnemy.X = spawnX;
            newEnemy.Y = spawnY;
            newEnemy.Health = newEnemy.Health + (2 * CurrentWave);
            newEnemy.VelocityY = newEnemy.VelocityY * (1f + 0.1f * CurrentWave);

            if (newEnemy is HeavyTankEnemy)
            {
                PointF center = _formationSlots[0];
                newEnemy.FormationTarget = new PointF(center.X - newEnemy.Width / 2f,
                                                      center.Y - newEnemy.Height / 2f);
            }
            else if (newEnemy is not TeroristEnemy)       
            {
                PointF slot = _formationSlots[_nextSlotIndex];
                newEnemy.FormationTarget = slot;
                newEnemy.formationAnchorX = slot.X;
            }

            _nextSlotIndex++;


            newlySpawnedEnemies.Add(newEnemy);
        }

      
        private BaseEnemy CreateRandomEnemyForCurrentWave()
        {
            int enemyTypeRate = _random.Next(100);

            if (CurrentWave == GameRules.BOSS_WAVE)                    
                return new HeavyTankEnemy(0f, 0f);


            if (CurrentWave >= 3 && enemyTypeRate < 25)
                return new ShooterEnemy(0f, 0f);
            if (CurrentWave >= 5 && enemyTypeRate < 40)     
                return new TeroristEnemy(0f, 0f);
            if (CurrentWave >= 2 && enemyTypeRate < 70)
                return new ScoutEnemy(0f, 0f);
            return new StandardEnemy(0f, 0f);
        }
    
    }
}

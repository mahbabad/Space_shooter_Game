using SpaceShooter.Models;
using SpaceShooter.Data;       
using System;
using System.Collections.Generic;
using System.Drawing;

namespace SpaceShooter.Core
{
    public class GameEngine
    {
        public GameSession Session { get; set; }
        public RectangleF GameArea { get; set; }

      private bool _isSave = false;
        
        private EnemySpawner _enemySpawner;
        private MovementController _movementController;
        private ShootingController _shooterController;
        public CollisionManager _collisionManager;
        private CoinManager _coinManager;
        private ScoreManager _scoreManager;
       
        private GameStatsRepository _gameStatsRepository;

        public GameEngine(RectangleF initialArea)
        {
            GameArea = initialArea;
            Session = new GameSession(initializePlayer() , GameArea);
            _movementController = new MovementController();
            _enemySpawner = new EnemySpawner(GameArea ,Session);
            _shooterController = new ShootingController();
            _coinManager = new CoinManager(Session);
            _scoreManager = new ScoreManager(Session);
            _collisionManager = new CollisionManager(_scoreManager, _coinManager);
            DatabaseConnection _databaseConnection = new DatabaseConnection();
            _gameStatsRepository = new GameStatsRepository(_databaseConnection);
        }

        private PlayerShip initializePlayer()
        {
            float startx = (GameArea.Width / 2) - 25f;
            float starty = -(GameArea.Height - 80f);
            PlayerShip initPlayer = new PlayerShip(startx, starty)
            {
                Health = GameRules.PlayerMaxHealth,
                IsActive = true
            };

            return initPlayer;
        }

        public void Update(float deltatime, InputState inputState)
        {
            if (Session.Status != Enums.GameStatus.playing) return;

            if (Session.Player != null && Session.Player.IsActive)
            {
                _movementController.UpdatePlayer(Session.Player, inputState, GameArea, deltatime);
            }

            if (inputState.IsShooting && Session.Player != null && Session.Player.IsActive)
            {
                _shooterController.UpdatePlayerShooting(Session.Player, inputState, Session.ActiveBullets, deltatime);
            }

            List<BaseEnemy> newlySpawned = new List<BaseEnemy>();
            _enemySpawner.Update(deltatime, Session.ActiveEnemies, newlySpawned);

            if (newlySpawned.Count > 0)
            {
                Session.ActiveEnemies.AddRange(newlySpawned);
            }

            _movementController.UpdateEnemies(Session.ActiveEnemies, GameArea, deltatime , Session.Player);
            _shooterController.UpdateEnemyShooting(Session.ActiveEnemies, Session.ActiveBullets, deltatime);
            _movementController.UpdateBullets(Session.ActiveBullets, GameArea, deltatime);
            _movementController.UpdateCoins(Session.ActiveCoins, GameArea, deltatime);

            _collisionManager.HandleAllCollisions(Session.Player, Session.ActiveEnemies, Session.ActiveBullets, Session.ActiveCoins);




            CleanupInactiveEntities();
            CheckGameOver(); 
            CheckGameFinish();
        }
        

        private void CleanupInactiveEntities()
        {
            Session.ActiveEnemies.RemoveAll(e => e.Health <= 0 || !e.IsActive || e.Y > GameArea.Bottom + 100 );
            Session.ActiveBullets.RemoveAll(b => !b.IsActive || b.Y > GameArea.Bottom + 100 || b.Y < GameArea.Top - 100 );
            Session.ActiveCoins.RemoveAll(c => !c.IsActive);
        }

        private void CheckGameOver()
        {
            if (Session.Player != null && Session.Player.Health <= 0)
            {
                Session.Status = Enums.GameStatus.gameOver;
                SaveGameData(); 
            }
        }

        private void CheckGameFinish()
        {
            if(Session.CurrentWave > 10)
            {
                Session.Status = Enums.GameStatus.finish;
                SaveGameData();
            }
        }

        public void SaveGameData()
        {
          
            _gameStatsRepository.UpdateHighScore(Session.Score);
            _gameStatsRepository.UpdateTotalCoins(Session.CoinsCollected);
        }
    }
}

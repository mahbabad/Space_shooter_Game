using System;
using System.Collections.Generic;
using SpaceShooter.Enums;
using SpaceShooter.Models;

namespace SpaceShooter.Core
{
    public class GameSession
    {
       public int CurrentWave {  get; set; }
       public int Score { get; set; }
       public int CoinsCollected { get; set; }
       public GameStatus Status { get; set; }

        public PlayerShip Player { get; set; }
        public RectangleF GameArea { get; set; }




        public List<BaseEnemy> ActiveEnemies { get; private set; }
        public List<Bullet> ActiveBullets { get; private set; }
        public List<Coin> ActiveCoins { get; private set; }

        public GameSession(PlayerShip P) 
        {
            ActiveEnemies = new List<BaseEnemy>();
            ActiveCoins = new List<Coin>();
            ActiveBullets = new List<Bullet>();
            Player = P;

            ResetSession();
        }

        public void ResetSession()
        {
            CurrentWave = 1;
            Score = 0;
            CoinsCollected = 0;
            Status = GameStatus.playing; 

            ActiveEnemies.Clear();
            ActiveBullets.Clear();
            ActiveCoins.Clear();

            Player = new PlayerShip(GameArea.Width/2 , GameArea.Height);
        }
    }
}

using System;
using System.Collections.Generic;
using SpaceShooter.Enums;
using SpaceShooter.Models;
using SpaceShooter.Data;

namespace SpaceShooter.Core
{
    public class GameSession
    {
       public int CurrentWave {  get; set; }
       public int Score { get; set; }
       public int CoinsCollected { get; set; }
       public GameStatus Status { get; set; }

        public PlayerShip Player { get; set; }
        private readonly ShipInfo _equippedShip;
        public RectangleF GameArea { get; set; }

        public List<ExplosionEffect> Effects { get; set; }




        public List<BaseEnemy> ActiveEnemies { get; private set; }
        public List<Bullet> ActiveBullets { get; private set; }
        public List<Coin> ActiveCoins { get; private set; }
        public List<Shield> ActiveShields { get; private set; } = new List<Shield>();

        public GameSession(RectangleF gameArea) 
        {
            GameArea = gameArea;
            ActiveEnemies = new List<BaseEnemy>();
            ActiveCoins = new List<Coin>();
            ActiveBullets = new List<Bullet>();
            Effects = new List<ExplosionEffect> ();
            var repo = new Data.ShopItemsRepository(new Data.DatabaseConnection());
            _equippedShip = repo.GetEquippedShip();

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
            ActiveShields.Clear();

            Player = new PlayerShip(
            GameArea.Width / 2 - 50f,          
            GameArea.Height - 110f);           
            Player.IsActive = true;

            if (_equippedShip != null)                       
            {
                Player.Speed = _equippedShip.Speed;
                Player.BulletDamage = _equippedShip.BulletDamage;
            }
        }
    }
}

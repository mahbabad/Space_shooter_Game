using SpaceShooter.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceShooter.Data
{
    public class BuyManager
    {
        public ShipInfo _selectedship;
        private DatabaseConnection _databaseConnection;
        private ShopItemsRepository _shopitemrepo;
        private GameStatsRepository _gameStatsRepository;

        public BuyManager() 
        {
            _databaseConnection = new DatabaseConnection();
            _shopitemrepo = new ShopItemsRepository(_databaseConnection);
            _gameStatsRepository = new GameStatsRepository(_databaseConnection);
        
        }

       public bool Buy(int id, int amount)
        {
            _selectedship =  _shopitemrepo.GetShipById(id);

            if (_selectedship == null) return false;

            if (_selectedship.Price <= amount)
            {
                _gameStatsRepository.UpdateTotalCoins(-_selectedship.Price);
                _shopitemrepo.SetPurchased(id);
                return true;

            }
            else
                return false;
        }

    }
}
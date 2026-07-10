using System;
using System.Collections.Generic;
using SpaceShooter.Models;
using SpaceShooter.Enums;

namespace SpaceShooter.Core
{
    public class CoinManager
    {
        private readonly GameSession _session;
        private readonly Random _random;

        public CoinManager(GameSession session)
        {
            _session = session;
            _random = new Random();
        }

        public List<Coin> CheckAndDropCoins(BaseEnemy deadEnemy)
        {
            List<Coin> newlySpawnedCoins = new List<Coin>();

            Coin droppedCoin = deadEnemy.TryDropCoin(_random);

            if (droppedCoin != null)
            {
                newlySpawnedCoins.Add(droppedCoin);
            }

            return newlySpawnedCoins;
        }

        public void CollectCoin(Coin coin)
        {
            int coinValue = (coin.type == CoinType.Gold) ? 5 : 1;

            _session.CoinsCollected += coinValue;

            coin.IsActive = false;
        }
    }
}

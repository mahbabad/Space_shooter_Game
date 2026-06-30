using Microsoft.Data.Sqlite;
using SpaceShooter.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceShooter.Data
{
    public class GameStatsRepository
    {
        private DatabaseConnection _MyDB;

        public GameStatsRepository(DatabaseConnection MyDB) 
        {
            _MyDB = MyDB;
        }

        private int GetSomething(string query)
        {
            using (var connection = _MyDB.GetConection())
            {
                connection.Open();
                using (var command = new SqliteCommand(query, connection))
                {
                    var result = command.ExecuteScalar();

                    return result != DBNull.Value ? Convert.ToInt32(result) : 0;
                }
            }
        }

        private void UpdateSomething(string query , int amount)
        {
            using (var connection = _MyDB.GetConection())
            {
                connection.Open();
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@amount", amount);
                    command.ExecuteNonQuery();
                }
            }
        }

        public int GetTotalCoins()
        {
            return GetSomething("SELECT TotalCoins FROM GameStats WHERE Id = 1");
        }

        public int GetHighScore()
        {
            return GetSomething("SELECT HighScore FROM GameStats WHERE Id = 1");
        }


        public void UpdateTotalCoins(int amount)
        {
            string query = "UPDATE GameStats SET TotalCoins = TotalCoins + @amount WHERE Id = 1";
            UpdateSomething(query,amount);
        }

        public void UpdateHighScore(int newScore)
        {
            string query = "UPDATE GameStats SET HighScore = @amount WHERE Id = 1 AND HighScore < @amount";
            UpdateSomething(query, newScore);
        }
    }
}

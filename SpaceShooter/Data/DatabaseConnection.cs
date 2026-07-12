using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.Sqlite;
using System.IO;


namespace SpaceShooter.Data
{
    public class DatabaseConnection
    {
        private readonly string _databasePath;
        private readonly string _connectionString;

        public DatabaseConnection()
        {
            _databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data_game.db");
            _connectionString = $"Data Source={_databasePath}";
        }

        public SqliteConnection GetConection()
        {
            return new SqliteConnection(_connectionString);
        }

        public void InitialDatabase()
        {
            CreateDatabaseFile();
            CreateTable();
            initialDatabaseIfNotExsit();
        }

        private void CreateDatabaseFile()
        {
            if (!File.Exists(_databasePath))
            {
                using FileStream fs = File.Create(_databasePath);
            }
        }

        private void CreateTable()
        {
            using var connection = GetConection();
            connection.Open();

            string createGameStatsTable = @"
                CREATE TABLE IF NOT EXISTS GameStats (
                    Id INTEGER PRIMARY KEY,
                    HighScore INTEGER NOT NULL,
                    TotalCoins INTEGER NOT NULL
                );";


            string createShopItemTable = @"

            CREATE TABLE IF NOT EXISTS shopItem (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            DisplayName TEXT NOT NULL,
            Price INTEGER NOT NULL,
            Speed REAL NOT NULL,
            BulletDamage INTEGER NOT NULL,
            IsPurchased INTEGER NOT NULL,
            IsEquipped INTEGER NOT NULL);";

            using var command = connection.CreateCommand();
            command.CommandText = createGameStatsTable + createShopItemTable;
            command.ExecuteNonQuery();
        }

        private void initialDatabaseIfNotExsit()
        {
            using var connection = GetConection();
            connection.Open();

            string insertDefaultGameStats = @"
                INSERT INTO GameStats (Id, HighScore, TotalCoins)
                SELECT 1, 0, 0
                WHERE NOT EXISTS (
                    SELECT 1 FROM GameStats WHERE Id = 1
                );
            ";

            string insertDefaultShopItems = @"
                INSERT OR IGNORE INTO shopItem (Id, DisplayName, Price, Speed, BulletDamage, IsPurchased, IsEquipped)
                VALUES
                (1, 'FANTASY SPACESHIP', 0,    200.0,  10, 1, 1),
                (2, 'SHAHED DRONE',      700,  180.0,  11, 0, 0),
                (3, 'RUSSIAN SUKHOI-57', 1700, 450.0,  12, 0, 0),
                (4, 'AMERICAN-F35',      2000, 500.0, 13, 0, 0),
                (5, 'IRANIAN MISSILE',   2500, 450.0, 15, 0, 0)";

            using var command = connection.CreateCommand();
            command.CommandText = insertDefaultGameStats + insertDefaultShopItems;
            command.ExecuteNonQuery();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.Sqlite;
using SpaceShooter.Models;

namespace SpaceShooter.Data
{
    public class ShopItemsRepository
    {
        private DatabaseConnection _Database;

        public ShopItemsRepository(DatabaseConnection Database)
        {
            _Database = Database;
        }

        public void SetEquipped(int id)
        {
            if (id < 1 || id > 5)
                return;

            using var connection = _Database.GetConection();
            connection.Open();

            using var command = connection.CreateCommand();

            command.CommandText = "UPDATE shopItem SET IsEquipped = 0;";
            command.ExecuteNonQuery();


            command.CommandText = "UPDATE shopItem SET IsEquipped = 1 WHERE Id = @Id;";
            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();
        }

        public bool SetPurchased(int id)
        {
            if (id < 1 || id > 5)
                return false;

            using var connection = _Database.GetConection();
            connection.Open();

            string query = "UPDATE shopItem SET IsPurchased = 1  WHERE Id = @Id ";

            using var command = connection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@Id", id);
            int rowCount = command.ExecuteNonQuery();

            return rowCount > 0;
        }


        public int GetEquippedId()
        {
            using var connection = _Database.GetConection();
            connection.Open();
            string query = "SELECT Id FROM shopItem WHERE IsEquipped  = 1 LIMIT 1";

            using (var command = connection.CreateCommand())
            {

                command.CommandText = query;

                var res = command.ExecuteScalar();

                return res != DBNull.Value ? Convert.ToInt32(res) : 0;

            }
        }

        public ShipInfo? GetEquippedShip()
        {
                using var connection = _Database.GetConection();
                connection.Open();
                string query = "SELECT * FROM shopItem WHERE IsEquipped = 1 LIMIT 1;";

                using (var command = new SqliteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new ShipInfo
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["DisplayName"].ToString() ?? string.Empty,
                            Price = Convert.ToInt32(reader["Price"]),
                            Speed = Convert.ToSingle(reader["Speed"]),
                            BulletDamage = Convert.ToInt32(reader["BulletDamage"]),
                            IsPurchased = true,
                            IsActive = true
                        };
                    }
                    return null;
                }
         }

        public ShipInfo GetShipById(int id)
        {
            using var connection = _Database.GetConection();
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM shopItem WHERE Id = @Id LIMIT 1";
            command.Parameters.AddWithValue("@Id", id);
            using var reader = command.ExecuteReader();
            if (!reader.Read()) return null;
            return new ShipInfo
            {
                Id = Convert.ToInt32(reader["Id"]),
                Name = reader["DisplayName"].ToString() ?? string.Empty,
                Price = Convert.ToInt32(reader["Price"]),
                Speed = Convert.ToSingle(reader["Speed"]),
                BulletDamage = Convert.ToInt32(reader["BulletDamage"]),
                IsPurchased = Convert.ToBoolean(reader["IsPurchased"]),
                IsActive = Convert.ToBoolean(reader["IsEquipped"])
            };
        }








    }

}

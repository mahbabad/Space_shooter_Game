using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.Sqlite;

namespace SpaceShooter.Data
{
    public class ShopItemsRepository
    {
        private DatabaseConnection _Database;

        public ShopItemsRepository(DatabaseConnection Database)
        {
            _Database = Database;
        }
        public bool IsPurchased(int id)
        {
            if (id < 1 || id > 5)
                return false;

            using (var connection = _Database.GetConection())
            {
                connection.Open();

                string query = "SELECT IsPurchased FROM ShopItem WHERE Id = @Id";

                using (var cmd = new SqliteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    object res = cmd.ExecuteScalar();

                    if (res == null)
                        return false;

                    return Convert.ToInt32(res) == 1;
                }
            }
        }

        public bool IsEquipped(int id)
        {
            if (id < 1 || id > 5)
                return false;

            using (var connection = _Database.GetConection())
            {
                connection.Open();

                string query = "SELECT IsEquipped FROM ShopItem WHERE Id = @Id";

                using (var cmd = new SqliteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    object res = cmd.ExecuteScalar();

                    if (res == null)
                        return false;

                    return Convert.ToInt32(res) == 1;
                }
            }
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

        public int GetItemPrice(int id)
        {
            if (id < 1 || id > 5)
                return -1;

            using var connection = _Database.GetConection();
            connection.Open();

            string query = "SELECT Price FROM shopItem WHERE Id = @Id;";

            using var command = connection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@Id", id);

            object res = command.ExecuteScalar();

            if (res == null || res == DBNull.Value)
                return 0;

            return Convert.ToInt32(res);
        }
    }
}

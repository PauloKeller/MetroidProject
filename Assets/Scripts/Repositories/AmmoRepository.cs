using Mono.Data.Sqlite;
using System.Collections.Generic;

public class AmmoRepository
{
    private readonly string _connectionString;

    public AmmoRepository(string databaseUri = "URI=file:MyDatabase.sqlite")
    {
        _connectionString = databaseUri;

        using (var connection = new SqliteConnection(_connectionString))
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = "CREATE TABLE IF NOT EXISTS Ammo (id INTEGER PRIMARY KEY, quantity INTEGER)";
                command.ExecuteNonQuery();
            }
        }
    }

    public void Update(int id, int quantity)
    {
        using var connection = new SqliteConnection(_connectionString);
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText = "INSERT OR REPLACE INTO Ammo (id, quantity) VALUES (@id, @quantity)";
        command.Parameters.AddWithValue("@id", id);
        command.Parameters.AddWithValue("@quantity", quantity);

        command.ExecuteNonQuery();
    }

    public List<AmmoStack> FindAll()
    {
        var items = new List<AmmoStack>();

        using (var connection = new SqliteConnection(_connectionString))
        {
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText = "SELECT id, quantity FROM Ammo";

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var type = (AmmoType)reader.GetInt32(0);
                var quantity = reader.GetInt32(1);

                var item = new AmmoStack(type, quantity);
                items.Add(item);
            }
        }

        return items;
    }
} 
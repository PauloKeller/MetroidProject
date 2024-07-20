using Mono.Data.Sqlite;
using System.Collections.Generic;
using System.Data;

public interface IResourceRepository
{
    public void Update(int id, int quantity);
    public List<ResourceStack> FindAll();
}

public class ResourceRepository : IResourceRepository
{
    private readonly string _connectionString;

    public ResourceRepository(string databaseUri = "URI=file:MyDatabase.sqlite")
    {
        _connectionString = databaseUri;

        using (var connection = new SqliteConnection(_connectionString))
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = "CREATE TABLE IF NOT EXISTS Resource (id INTEGER PRIMARY KEY, quantity INTEGER)";
                command.ExecuteNonQuery();
            }
        }
    }

    public void Update(int id, int quantity)
    {
        using var connection = new SqliteConnection(_connectionString);
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText = "INSERT OR REPLACE INTO Resource (id, quantity) VALUES (@id, @quantity)";
        command.Parameters.AddWithValue("@id", id);
        command.Parameters.AddWithValue("@quantity", quantity);

        command.ExecuteNonQuery();
    }

    public List<ResourceStack> FindAll()
    {
        var items = new List<ResourceStack>();

        using (var connection = new SqliteConnection(_connectionString))
        {
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText = "SELECT id, quantity FROM Resource";

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var type = (ResourceType)reader.GetInt32(0);
                var quantity = reader.GetInt32(1);

                var item = new ResourceStack(type, quantity);
                items.Add(item);
            }
        }

        return items;
    }
}
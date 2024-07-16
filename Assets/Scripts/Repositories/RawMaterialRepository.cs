using Mono.Data.Sqlite;
using System.Collections.Generic;
using System.Data;

public interface IRawMaterialRepository
{
    public void Update(RawMaterialInventorySlot rawMaterialInventorySlot);
    public ResourceStack FindByType(int type);
    public List<ResourceStack> FindAll();
}

public class RawMaterialRepository : IRawMaterialRepository
{
    IDbConnection databaseConnection;

    public RawMaterialRepository()
    {
        string databaseUri = "URI=file:MyDatabase.sqlite";
        databaseConnection = new SqliteConnection(databaseUri);
        databaseConnection.Open();

        IDbCommand dbCommandCreateTable = databaseConnection.CreateCommand();
        dbCommandCreateTable.CommandText = "CREATE TABLE IF NOT EXISTS RawMaterial (id INTEGER PRIMARY KEY, type TEXT, quantity INTEGER)";
        dbCommandCreateTable.ExecuteReader();
        databaseConnection.Close();
    }

    public void Update(RawMaterialInventorySlot rawMaterialInventorySlot)
    {
        databaseConnection.Open();
        IDbCommand databaseCommand = databaseConnection.CreateCommand();
        databaseCommand.CommandText = $"INSERT OR REPLACE INTO RawMaterial (id, type, quantity) VALUES ({(int)rawMaterialInventorySlot.rawMaterial.Type}, {(int)rawMaterialInventorySlot.rawMaterial.Type}, {(int)rawMaterialInventorySlot.quantity})";
        databaseCommand.ExecuteNonQuery();

        databaseConnection.Close();
    }

    public ResourceStack FindByType(int type)
    {
        ResourceStack item = new ResourceStack();
        databaseConnection.Open();
        IDbCommand databaseCommand = databaseConnection.CreateCommand();
        databaseCommand.CommandText = $"SELECT * FROM RawMaterial WHERE id = {type}";
        IDataReader dataReader = databaseCommand.ExecuteReader();
        while (dataReader.Read())
        {
            int readerId = dataReader.GetInt32(0);
            ResourceType readerType = (ResourceType)dataReader.GetInt32(1);
            int readerAmount = dataReader.GetInt32(2);

            item = new ResourceStack(type: readerType, amount: readerAmount);
        }

        databaseConnection.Close();
        return item;
    }

    public List<ResourceStack> FindAll()
    {
        List<ResourceStack> items = new List<ResourceStack>();
        databaseConnection.Open();
        IDbCommand databaseCommand = databaseConnection.CreateCommand();
        databaseCommand.CommandText = $"SELECT * FROM RawMaterial";
        IDataReader dataReader = databaseCommand.ExecuteReader();

        while (dataReader.Read())
        {
            int readerId = dataReader.GetInt32(0);
            ResourceType readerType = (ResourceType)dataReader.GetInt32(1);
            int readerAmount = dataReader.GetInt32(2);

            ResourceStack item = new ResourceStack(type: readerType, amount: readerAmount);
            items.Add(item);
        }

        databaseConnection.Close();
        return items;
    }
}
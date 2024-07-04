using Mono.Data.Sqlite;
using System.Data;
using UnityEngine;

public interface IRawMaterialInventoryRepository 
{
    public void Update(RawMaterialInventorySlot rawMaterialInventorySlot);
    public RawMaterialInventorySlot? FindByType(int type);
}

public class RawMaterialInventoryRepository: IRawMaterialInventoryRepository
{
    IDbConnection databaseConnection;

    public RawMaterialInventoryRepository(string databaseUri) 
    {
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

    public RawMaterialInventorySlot? FindByType(int type)
    {
        RawMaterialInventorySlot item = null;
        databaseConnection.Open();
        IDbCommand databaseCommand = databaseConnection.CreateCommand();
        databaseCommand.CommandText = $"SELECT * FROM RawMaterial WHERE id = {type}";
        IDataReader dataReader = databaseCommand.ExecuteReader();
        while (dataReader.Read())
        {
            int readerId = dataReader.GetInt32(0);
            RawMaterialType readerType = (RawMaterialType)dataReader.GetInt32(1);
            int readerQuantity = dataReader.GetInt32(2);

            item = new RawMaterialInventorySlot(type: readerType, quantity: readerQuantity);
            Debug.Log($"find item: {(item.rawMaterial)}, with quantity {item.quantity}");
        }

        databaseConnection.Close();
        return item;
    }
}
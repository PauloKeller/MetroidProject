using Codice.CM.Common.Selectors;
using Mono.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using UnityEngine;

public interface IRawMaterialRepository 
{
    public void Update(RawMaterialInventorySlot rawMaterialInventorySlot);
    public RawMaterialInventorySlot? FindByType(int type);
    public List<RawMaterialStack> FindAll();
}

public class RawMaterialRepository: IRawMaterialRepository
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

    public List<RawMaterialStack> FindAll() 
    {
        List<RawMaterialStack> items = new List<RawMaterialStack>();
        databaseConnection.Open();
        IDbCommand databaseCommand = databaseConnection.CreateCommand();
        databaseCommand.CommandText = $"SELECT * FROM RawMaterial";
        IDataReader dataReader = databaseCommand.ExecuteReader();
        
        while (dataReader.Read())
        {
            int readerId = dataReader.GetInt32(0);
            RawMaterialType readerType = (RawMaterialType)dataReader.GetInt32(1);
            int readerQuantity = dataReader.GetInt32(2);

            RawMaterialStack item = new RawMaterialStack(amount: readerQuantity, rawMaterialType: readerType);
            Debug.Log($"find item: {(item.rawMaterial)}, with amount {item.amount}");
            items.Append(item);
        }

        databaseConnection.Close();
        return items;
    }
}
using System.Collections.Generic;
using System.Data;
using Mono.Data.Sqlite;
using UnityEngine;

public class Inventory 
{
    string dbUri = "URI=file:MyDatabase.sqlite";

    public Inventory(List<RawMaterialInventorySlot> rawMaterialInventorySlots, 
        List<MachineGunAmmoInventorySlot> MachineGunInventorySlot) {
        this.rawMaterialInventorySlots = rawMaterialInventorySlots;
        this.MachineGunInventorySlot = MachineGunInventorySlot;

        int hitCount = 0;

        IDbConnection dbConnection = CreateAndOpenDatabase();
        IDbCommand dbCommandReadValues = dbConnection.CreateCommand();
        dbCommandReadValues.CommandText = "SELECT * FROM HitCountTableSimple";
        IDataReader dataReader = dbCommandReadValues.ExecuteReader();

        while (dataReader.Read())
        {
            hitCount = dataReader.GetInt32(1);
        }

        dbConnection.Close();
    }

    List<RawMaterialInventorySlot> rawMaterialInventorySlots;
    public List<RawMaterialInventorySlot> RawMaterialInventorySlots 
    {
        get 
        { 
            return rawMaterialInventorySlots;
        }
        set 
        {
            rawMaterialInventorySlots = value;
        }
    }

    public List<MachineGunAmmoInventorySlot> MachineGunInventorySlot;

    private IDbConnection CreateAndOpenDatabase() // 3
    {
        // Open a connection to the database.
        string dbUri = "URI=file:MyDatabase.sqlite"; // 4
        IDbConnection dbConnection = new SqliteConnection(dbUri); // 5
        dbConnection.Open(); // 6

        // Create a table for the hit count in the database if it does not exist yet.
        IDbCommand dbCommandCreateTable = dbConnection.CreateCommand(); // 6
        dbCommandCreateTable.CommandText = "CREATE TABLE IF NOT EXISTS HitCountTableSimple (id INTEGER PRIMARY KEY, hits INTEGER )"; // 7
        dbCommandCreateTable.ExecuteReader(); // 8

        return dbConnection;
    }
}
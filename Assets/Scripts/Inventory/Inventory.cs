using System.Collections.Generic;
using System.Data;
using Mono.Data.Sqlite;
using UnityEngine;

public class Inventory 
{
    public Inventory(List<RawMaterialInventorySlot> rawMaterialInventorySlots, 
        List<MachineGunAmmoInventorySlot> MachineGunInventorySlot) {
        this.rawMaterialInventorySlots = rawMaterialInventorySlots;
        this.MachineGunInventorySlot = MachineGunInventorySlot;
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
}
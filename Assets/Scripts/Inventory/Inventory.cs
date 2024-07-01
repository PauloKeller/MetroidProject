using System.Collections.Generic;

public class Inventory 
{
    public Inventory(RawMaterialInventorySlot metalInventorySlot, 
        RawMaterialInventorySlot fuelInventorySlot,
        RawMaterialInventorySlot energyInventorySlot,
        RawMaterialInventorySlot chemicalInventorySlot,
        RawMaterialInventorySlot radioactiveInventorySlot) {
     
        rawMaterialInventorySlots = new List<RawMaterialInventorySlot>
        {
            metalInventorySlot,
            fuelInventorySlot,
            energyInventorySlot,
            chemicalInventorySlot,
            radioactiveInventorySlot
        };
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
}
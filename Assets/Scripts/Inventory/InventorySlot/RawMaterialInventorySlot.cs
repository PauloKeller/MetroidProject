using UnityEngine;

public class RawMaterialInventorySlot
{
    // TODO: Pass a enum as type?
    public IRawMaterial rawMaterial;
    public int quantity;

    public RawMaterialInventorySlot(IRawMaterial rawMaterial, int quantity)
    {
        this.rawMaterial = rawMaterial;
        this.quantity = quantity;
    }

    public bool CanUpdateQuantity(int amount) 
    { 
        if ((this.quantity + amount) > 0) 
        {
            return true;
        }

        return false;
    }
}
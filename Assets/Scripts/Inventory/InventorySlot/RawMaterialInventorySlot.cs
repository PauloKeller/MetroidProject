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

    public RawMaterialInventorySlot(RawMaterialType type, int quantity) 
    { 
        this.quantity = quantity;
        switch (type) 
        { 
            case RawMaterialType.Metal: 
                this.rawMaterial = new MetalRawMaterial();
                break;
            case RawMaterialType.Chemical:
                this.rawMaterial = new ChemicalRawMaterial();
                break;
            case RawMaterialType.Fuel:
                this.rawMaterial = new FuelRawMaterial();
                break;
            case RawMaterialType.Energy:
                this.rawMaterial = new EnergyRawMaterial();
                break;
            case RawMaterialType.Radioactive:
                this.rawMaterial = new RadioactiveRawMaterial();
                break;
        }
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
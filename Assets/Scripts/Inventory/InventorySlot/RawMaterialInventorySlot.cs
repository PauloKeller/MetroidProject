using UnityEngine;

public class RawMaterialInventorySlot
{
    // TODO: Pass a enum as type?
    public IResource rawMaterial;
    public int quantity;

    public RawMaterialInventorySlot(IResource rawMaterial, int quantity)
    {
        this.rawMaterial = rawMaterial;
        this.quantity = quantity;
    }

    public RawMaterialInventorySlot(ResourceType type, int quantity) 
    { 
        this.quantity = quantity;
        switch (type) 
        { 
            case ResourceType.Metal: 
                this.rawMaterial = new MetalResource();
                break;
            case ResourceType.Chemical:
                this.rawMaterial = new ChemicalResource();
                break;
            case ResourceType.Flammable:
                this.rawMaterial = new FlammableResource();
                break;
            case ResourceType.Energy:
                this.rawMaterial = new EnergyResource();
                break;
            case ResourceType.Nuclear:
                this.rawMaterial = new NuclearResource();
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
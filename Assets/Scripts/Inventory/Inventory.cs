public class Inventory 
{
    public Inventory(RawMaterialInventorySlot ironInventorySlot) {
        this.ironInventorySlot = ironInventorySlot;
    }

    private RawMaterialInventorySlot ironInventorySlot;

    public RawMaterialInventorySlot IronInventorySlot
    { 
        get { 
            return ironInventorySlot; 
        }
        set 
        {
            ironInventorySlot = value;
        }
    }
}
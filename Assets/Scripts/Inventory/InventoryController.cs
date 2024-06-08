using UnityEngine;

public class InventoryController : MonoBehaviour
{
    private InventoryUseCase useCase;

    private void Awake()
    {
        RawMaterialInventorySlot ironInventorySlot = new RawMaterialInventorySlot(rawMaterial: new IronOre(), quantity: 100);
        Inventory inventory = new Inventory(ironInventorySlot);
        this.useCase = new InventoryUseCase(inventory: inventory);
    }

    public void OnPutMaterial() 
    {
        useCase.UpdateRawMaterialQuantity(new IronOre(), -110);
    }
}
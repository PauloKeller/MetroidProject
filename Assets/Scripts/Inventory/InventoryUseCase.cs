
// TODO: Create Interface
using UnityEngine;

public class InventoryUseCase
{
    Inventory inventory;

    public InventoryUseCase(Inventory inventory)
    {
        this.inventory = inventory;
    }

    public void UpdateRawMaterialQuantity(IRawMaterial rawMaterial, int amount) 
    {
        Debug.Log($"Updating {rawMaterial} with amount: {amount}");

        if (rawMaterial is IronOre)
        {
            try
            {
                if (!inventory.IronInventorySlot.CanUpdateQuantity(amount))
                {
                    var code = InventorySlotExceptionCode.NegativeQuantity;
                    throw new InvetorySlotUpdateException(code: code);
                }

                var quantity = inventory.IronInventorySlot.quantity;
                var newQuantity = quantity += amount;
                var updatedInventorySlot = new RawMaterialInventorySlot(rawMaterial: rawMaterial, quantity: newQuantity);

                Debug.Log($"Raw material: {inventory.IronInventorySlot.rawMaterial}, quantity: {inventory.IronInventorySlot.quantity}");
                inventory.IronInventorySlot = updatedInventorySlot;
                Debug.Log($"Raw material: {inventory.IronInventorySlot.rawMaterial}, new quantity: {inventory.IronInventorySlot.quantity}");
            }
            catch (InvetorySlotUpdateException e)
            {
                Debug.Log($"Fail to update raw material, exception code: {e.Code}");
            }
        }
    }
}

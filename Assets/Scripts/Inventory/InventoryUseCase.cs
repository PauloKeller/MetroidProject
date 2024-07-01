using UnityEngine;

public interface IInventoryUseCase 
{
    public void UpdateRawMaterialQuantity(IRawMaterial rawMaterial, int amount);
}

public class InventoryUseCase: IInventoryUseCase
{
    private Inventory inventory;

    public InventoryUseCase(Inventory inventory)
    {
        this.inventory = inventory;
    }

    public void UpdateRawMaterialQuantity(IRawMaterial rawMaterial, int amount)
    {
        for (int index = 0; index < inventory.RawMaterialInventorySlots.Count; index++) 
        {
            var item = inventory.RawMaterialInventorySlots[index];

            if (item.rawMaterial.GetType() == rawMaterial.GetType()) 
            {
                // TODO: Maybe too overkill to check the amount
                if (!item.CanUpdateQuantity(amount))
                {
                    var code = InventorySlotExceptionCode.NegativeQuantity;
                    throw new InventorySlotUpdateException(code: code);
                }

                var newQuantity = item.quantity + amount;
                var updatedInventorySlot = new RawMaterialInventorySlot(rawMaterial: rawMaterial, quantity: newQuantity);

                Debug.Log($"Updating {rawMaterial} with {newQuantity}");

                inventory.RawMaterialInventorySlots[index] = updatedInventorySlot;
            }
        }
    }
}

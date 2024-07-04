using UnityEngine;

public interface IInventoryUseCase 
{
    public void UpdateRawMaterialQuantity(IRawMaterial rawMaterial, int amount);
    public void GetRawMaterialQuantity(IRawMaterial rawMaterial);
}

public class InventoryUseCase: IInventoryUseCase
{
    IRawMaterialInventoryRepository rawMaterialRepository;
    string dbUri = "URI=file:MyDatabase.sqlite";
    Inventory inventory;

    public InventoryUseCase(Inventory inventory, IRawMaterialInventoryRepository rawMaterialRepository)
    {
        this.inventory = inventory;
        this.rawMaterialRepository = rawMaterialRepository;
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

                rawMaterialRepository.Update(updatedInventorySlot);

                inventory.RawMaterialInventorySlots[index] = updatedInventorySlot;
            }
        }
    }

    public void GetRawMaterialQuantity(IRawMaterial rawMaterial) 
    {
        var rawMaterialSlot = rawMaterialRepository.FindByType((int)rawMaterial.Type);
        Debug.Log($"Raw material found {rawMaterialSlot.rawMaterial}, quantity: {rawMaterialSlot.quantity}");
    }
}

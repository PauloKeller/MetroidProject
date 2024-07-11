using UnityEngine;

public interface IInventoryUseCase 
{
}

public class InventoryUseCase: IInventoryUseCase
{
    IRawMaterialRepository rawMaterialRepository;
    string dbUri = "URI=file:MyDatabase.sqlite";
    Inventory inventory;

    public InventoryUseCase(Inventory inventory, IRawMaterialRepository rawMaterialRepository)
    {
        this.inventory = inventory;
        this.rawMaterialRepository = rawMaterialRepository;
    }
}

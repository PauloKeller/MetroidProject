using UnityEngine;

public interface IInventoryUseCase 
{
}

public class InventoryUseCase: IInventoryUseCase
{
    IResourceRepository rawMaterialRepository;
    string dbUri = "URI=file:MyDatabase.sqlite";
    Inventory inventory;

    public InventoryUseCase(Inventory inventory, IResourceRepository rawMaterialRepository)
    {
        this.inventory = inventory;
        this.rawMaterialRepository = rawMaterialRepository;
    }
}

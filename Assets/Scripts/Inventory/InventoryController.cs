using UnityEngine;

public class InventoryController : MonoBehaviour
{
    private IInventoryUseCase useCase;

    private void Awake()
    {
        RawMaterialInventorySlot metalInventorySlot = new RawMaterialInventorySlot(rawMaterial: new MetalRawMaterial(), quantity: 100);
        RawMaterialInventorySlot fuelInventorySlot = new RawMaterialInventorySlot(rawMaterial: new FuelRawMaterial(), quantity: 50);
        RawMaterialInventorySlot energyInventorySlot = new RawMaterialInventorySlot(rawMaterial: new EnergyRawMaterial(), quantity: 50);
        RawMaterialInventorySlot chemicalInventorySlot = new RawMaterialInventorySlot(rawMaterial: new ChemicalRawMaterial(), quantity: 50);
        RawMaterialInventorySlot radioactiveInventorySlot = new RawMaterialInventorySlot(rawMaterial: new RadioactiveRawMaterial(), quantity: 50);

        Inventory inventory = new Inventory(metalInventorySlot: metalInventorySlot, 
            fuelInventorySlot: fuelInventorySlot, 
            energyInventorySlot: energyInventorySlot,
            chemicalInventorySlot: chemicalInventorySlot,
            radioactiveInventorySlot: radioactiveInventorySlot);
        this.useCase = new InventoryUseCase(inventory: inventory);
    }

    public void OnPutMaterial()
    {
        useCase.UpdateRawMaterialQuantity(new EnergyRawMaterial(), 20);
    }
}
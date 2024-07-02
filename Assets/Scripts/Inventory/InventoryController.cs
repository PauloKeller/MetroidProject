using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    private IInventoryUseCase useCase;

    private void Awake()
    {
        List<RawMaterialInventorySlot> rawMaterialSlots = new List<RawMaterialInventorySlot>
        {
            new RawMaterialInventorySlot(rawMaterial: new FuelRawMaterial(), quantity: 50),
            new RawMaterialInventorySlot(rawMaterial: new MetalRawMaterial(), quantity: 100),
            new RawMaterialInventorySlot(rawMaterial: new EnergyRawMaterial(), quantity: 50),
            new RawMaterialInventorySlot(rawMaterial: new ChemicalRawMaterial(), quantity: 50),
            new RawMaterialInventorySlot(rawMaterial: new RadioactiveRawMaterial(), quantity: 50),
        };

        List<MachineGunAmmoInventorySlot> machineGunSlots = new List<MachineGunAmmoInventorySlot>
        {
            new MachineGunAmmoInventorySlot(Amount: 0, AmmoReceipt: new MetalMachineGunAmmoReceipt()),
        };

        Inventory inventory = new Inventory(rawMaterialSlots, MachineGunInventorySlot: machineGunSlots);
        this.useCase = new InventoryUseCase(inventory: inventory);
    }

    public void OnPutMaterial()
    {
        useCase.UpdateRawMaterialQuantity(new EnergyRawMaterial(), 20);
    }
}
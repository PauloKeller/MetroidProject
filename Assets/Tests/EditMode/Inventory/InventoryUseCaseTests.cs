using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

[TestFixture]
public class InventoryUseCaseTests
{
    private Inventory inventory;
    private RawMaterialInventorySlot metalInventorySlot;
    private RawMaterialInventorySlot fuelInventorySlot;
    private RawMaterialInventorySlot energyInventorySlot;
    private RawMaterialInventorySlot chemicalInventorySlot;
    private RawMaterialInventorySlot radioactiveInventorySlot;

    [SetUp]
    public void SetUp()
    {
        metalInventorySlot = new RawMaterialInventorySlot(rawMaterial: new MetalResource(), quantity: 10);
        fuelInventorySlot = new RawMaterialInventorySlot(rawMaterial: new FlammableResource(), quantity: 500);
        energyInventorySlot = new RawMaterialInventorySlot(rawMaterial: new EnergyResource(), quantity: 330);
        chemicalInventorySlot = new RawMaterialInventorySlot(rawMaterial: new ChemicalResource(), quantity: 120);
        radioactiveInventorySlot = new RawMaterialInventorySlot(rawMaterial: new NuclearResource(), quantity: 247);

        List <RawMaterialInventorySlot> rawMaterialSlots = new List<RawMaterialInventorySlot>
        {
            metalInventorySlot,
            fuelInventorySlot,
            energyInventorySlot,
            chemicalInventorySlot,
            radioactiveInventorySlot
        };

        List<MachineGunAmmoInventorySlot> machineGunAmmoSlots = new List<MachineGunAmmoInventorySlot>();

        inventory = new Inventory(rawMaterialSlots, machineGunAmmoSlots);
    }


    [Test]
    public void UpdateRawMaterialQuantity_ShouldUpdateQuantity()
    {
        // Arrange   
       // var usecase = new inventoryusecase(inventory);
       // int amount = 3;

       // act
       // usecase.updaterawmaterialquantity(new metalrawmaterial(), amount);

       // assert
       //var metalslot = inventory.rawmaterialinventoryslots.where(x => x.rawmaterial.gettype() == typeof(metalrawmaterial)).first();
       // assert.areequal(13, metalslot.quantity);
    }

    [Test]
    public void UpdateRawMaterialQuantity_ShouldNotUpdateForDifferentRawMaterial()
    {
        // Arrange
        var rawMaterial1 = new EnergyResource();
        var rawMaterial2 = new ChemicalResource();
        var slot1 = new RawMaterialInventorySlot(rawMaterial1, 10);
        var slot2 = new RawMaterialInventorySlot(rawMaterial2, 5);
        
        //var useCase = new InventoryUseCase(inventory);
        //int amount = 3;

        //// Act
        //useCase.UpdateRawMaterialQuantity(rawMaterial2, amount);

        //// Assert
        //Assert.AreEqual(5, slot2.quantity); // Check if quantity remains unchanged
    }

    [Test]
    public void UpdateRawMaterialQuantity_ShouldThrowExceptionOnNegativeUpdate()
    {
        //var useCase = new InventoryUseCase(inventory);
        //int amount = -15;

        //// Act & Assert
        //Assert.Throws<InventorySlotUpdateException>(() => useCase.UpdateRawMaterialQuantity(new MetalRawMaterial(), amount));
    }

}
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
        metalInventorySlot = new RawMaterialInventorySlot(rawMaterial: new MetalRawMaterial(), quantity: 10);
        fuelInventorySlot = new RawMaterialInventorySlot(rawMaterial: new FuelRawMaterial(), quantity: 500);
        energyInventorySlot = new RawMaterialInventorySlot(rawMaterial: new EnergyRawMaterial(), quantity: 330);
        chemicalInventorySlot = new RawMaterialInventorySlot(rawMaterial: new ChemicalRawMaterial(), quantity: 120);
        radioactiveInventorySlot = new RawMaterialInventorySlot(rawMaterial: new RadioactiveRawMaterial(), quantity: 247);

        List <RawMaterialInventorySlot> rawMaterialSlots = new List<RawMaterialInventorySlot>
        {
            metalInventorySlot,
            fuelInventorySlot,
            energyInventorySlot,
            chemicalInventorySlot,
            radioactiveInventorySlot
        };

        inventory = new Inventory(rawMaterialSlots);
    }


    [Test]
    public void UpdateRawMaterialQuantity_ShouldUpdateQuantity()
    {
        // Arrange   
        var useCase = new InventoryUseCase(inventory);
        int amount = 3;

        // Act
        useCase.UpdateRawMaterialQuantity(new MetalRawMaterial(), amount);

        // Assert
        var metalSlot = inventory.RawMaterialInventorySlots.Where(x => x.rawMaterial.GetType() == typeof(MetalRawMaterial)).First();
        Assert.AreEqual(13, metalSlot.quantity); 
    }

    [Test]
    public void UpdateRawMaterialQuantity_ShouldNotUpdateForDifferentRawMaterial()
    {
        // Arrange
        var rawMaterial1 = new EnergyRawMaterial();
        var rawMaterial2 = new ChemicalRawMaterial();
        var slot1 = new RawMaterialInventorySlot(rawMaterial1, 10);
        var slot2 = new RawMaterialInventorySlot(rawMaterial2, 5);
        
        var useCase = new InventoryUseCase(inventory);
        int amount = 3;

        // Act
        useCase.UpdateRawMaterialQuantity(rawMaterial2, amount);

        // Assert
        Assert.AreEqual(5, slot2.quantity); // Check if quantity remains unchanged
    }

    [Test]
    public void UpdateRawMaterialQuantity_ShouldThrowExceptionOnNegativeUpdate()
    {
        var useCase = new InventoryUseCase(inventory);
        int amount = -15;

        // Act & Assert
        Assert.Throws<InventorySlotUpdateException>(() => useCase.UpdateRawMaterialQuantity(new MetalRawMaterial(), amount));
    }

}
using NUnit.Framework;
using NUnit.Framework.Constraints;
using System.Collections.Generic;

[TestFixture]
public class InventoryTests
{
    private RawMaterialInventorySlot metalInventorySlot;
    private RawMaterialInventorySlot fuelInventorySlot;
    private RawMaterialInventorySlot energyInventorySlot;
    private RawMaterialInventorySlot chemicalInventorySlot;
    private RawMaterialInventorySlot radioactiveInventorySlot;
    private Inventory inventory;

    [SetUp]
    public void SetUp()
    {
        metalInventorySlot = new RawMaterialInventorySlot(rawMaterial: new MetalRawMaterial(), quantity: 700);
        fuelInventorySlot = new RawMaterialInventorySlot(rawMaterial: new FuelRawMaterial(), quantity: 500);
        energyInventorySlot = new RawMaterialInventorySlot(rawMaterial: new EnergyRawMaterial(), quantity: 330);
        chemicalInventorySlot = new RawMaterialInventorySlot(rawMaterial: new ChemicalRawMaterial(), quantity: 120);
        radioactiveInventorySlot = new RawMaterialInventorySlot(rawMaterial: new RadioactiveRawMaterial(), quantity: 247);

        List<RawMaterialInventorySlot> rawMaterialSlots = new List<RawMaterialInventorySlot>
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
    public void Constructor_ShouldInitializeInventorySlots()
    {
        // Arrange
        var expectedSlots = new List<RawMaterialInventorySlot>
        {
            metalInventorySlot,
            fuelInventorySlot,
            energyInventorySlot,
            chemicalInventorySlot,
            radioactiveInventorySlot
        };

        // Act
        var actualSlots = inventory.RawMaterialInventorySlots;

        // Assert
        CollectionAssert.AreEqual(expectedSlots, actualSlots);
    }

    [Test]
    public void RawMaterialInventorySlots_Setter_ShouldUpdateInventorySlots()
    {
        // Arrange
        var newSlots = new List<RawMaterialInventorySlot>
        {
            new RawMaterialInventorySlot(rawMaterial: new MetalRawMaterial(), quantity: 700),
            new RawMaterialInventorySlot(rawMaterial: new FuelRawMaterial(), quantity: 500),
            new RawMaterialInventorySlot(rawMaterial: new EnergyRawMaterial(), quantity: 33),
            new RawMaterialInventorySlot(rawMaterial: new ChemicalRawMaterial(), quantity: 120),
            new RawMaterialInventorySlot(rawMaterial: new RadioactiveRawMaterial(), quantity: 247),
        };

        // Act
        inventory.RawMaterialInventorySlots = newSlots;
        var actualSlots = inventory.RawMaterialInventorySlots;

        // Assert
        CollectionAssert.AreEqual(newSlots, actualSlots);
    }
}

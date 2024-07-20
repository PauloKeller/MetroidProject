using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class ChemicalFuelReceiptTests
{
    private ChemicalFuelReceipt chemicalFuelReceipt;

    [SetUp]
    public void SetUp()
    {
        // Initialize the ChemicalFuelReceipt with a CryogenicFuelReceipt
        chemicalFuelReceipt = new ChemicalFuelReceipt(new CryogenicFuelReceipt(new FlammableFuelReceipt(new BaseAmmoReceipt())));
    }

    [Test]
    public void ResourceRequirements_ShouldReturnUpdatedValues()
    {
        // Arrange
        var expectedResourceRequirements = new Dictionary<ResourceType, int>
        {
            { ResourceType.Metal, 0 },
            { ResourceType.Flammable, 7 }, // base: 5 (from FlammableFuelReceipt) + 1
            { ResourceType.Cryogenic, 3 }, // base: 2 (from CryogenicFuelReceipt) + 1
            { ResourceType.Chemical, 3 }, // base: 0 + 3
            { ResourceType.Energy, 0 },
            { ResourceType.Nuclear, 0 }
        };

        // Act
        var actualResourceRequirements = chemicalFuelReceipt.ResourceRequirements;

        // Assert
        CollectionAssert.AreEquivalent(expectedResourceRequirements, actualResourceRequirements);
    }

    [Test]
    public void Name_ShouldReturnChemicalFuel()
    {
        // Arrange
        var expectedName = "Chemical Fuel";

        // Act
        var actualName = chemicalFuelReceipt.Name;

        // Assert
        Assert.AreEqual(expectedName, actualName);
    }

    [Test]
    public void AmmoType_ShouldReturnChemicalFuel()
    {
        // Arrange
        var expectedAmmoType = AmmoType.ChemicalFuel;

        // Act
        var actualAmmoType = chemicalFuelReceipt.AmmoType;

        // Assert
        Assert.AreEqual(expectedAmmoType, actualAmmoType);
    }
}
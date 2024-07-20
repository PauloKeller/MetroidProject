using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class CryogenicFuelReceiptTests
{
    private CryogenicFuelReceipt cryogenicFuelReceipt;

    [SetUp]
    public void SetUp()
    {
        // Initialize the CryogenicFuelReceipt with a FlammableFuelReceipt
        cryogenicFuelReceipt = new CryogenicFuelReceipt(new FlammableFuelReceipt(new BaseAmmoReceipt()));
    }

    [Test]
    public void ResourceRequirements_ShouldReturnUpdatedValues()
    {
        // Arrange
        var expectedResourceRequirements = new Dictionary<ResourceType, int>
        {
            { ResourceType.Metal, 0 },
            { ResourceType.Flammable, 6 }, // base: 0 + 5 (from FlammableFuelReceipt) + 1
            { ResourceType.Cryogenic, 2 }, // base: 0 + 2
            { ResourceType.Chemical, 0 },
            { ResourceType.Energy, 0 },
            { ResourceType.Nuclear, 0 }
        };

        // Act
        var actualResourceRequirements = cryogenicFuelReceipt.ResourceRequirements;

        // Assert
        CollectionAssert.AreEquivalent(expectedResourceRequirements, actualResourceRequirements);
    }

    [Test]
    public void Name_ShouldReturnCryogenicFuel()
    {
        // Arrange
        var expectedName = "Cryogenic Fuel";

        // Act
        var actualName = cryogenicFuelReceipt.Name;

        // Assert
        Assert.AreEqual(expectedName, actualName);
    }

    [Test]
    public void AmmoType_ShouldReturnCryogenicFuel()
    {
        // Arrange
        var expectedAmmoType = AmmoType.CryogenicFuel;

        // Act
        var actualAmmoType = cryogenicFuelReceipt.AmmoType;

        // Assert
        Assert.AreEqual(expectedAmmoType, actualAmmoType);
    }
}
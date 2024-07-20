using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class FlammableFuelReceiptTests
{
    private FlammableFuelReceipt flammableFuelReceipt;

    [SetUp]
    public void SetUp()
    {
        // Initialize the FlammableFuelReceipt with a BaseAmmoReceipt
        flammableFuelReceipt = new FlammableFuelReceipt(new BaseAmmoReceipt());
    }

    [Test]
    public void ResourceRequirements_ShouldReturnUpdatedValues()
    {
        // Arrange
        var expectedResourceRequirements = new Dictionary<ResourceType, int>
        {
            { ResourceType.Metal, 0 },
            { ResourceType.Flammable, 5 }, // base: 0 + 5
            { ResourceType.Cryogenic, 0 },
            { ResourceType.Chemical, 0 },
            { ResourceType.Energy, 0 },
            { ResourceType.Nuclear, 0 }
        };

        // Act
        var actualResourceRequirements = flammableFuelReceipt.ResourceRequirements;

        // Assert
        CollectionAssert.AreEquivalent(expectedResourceRequirements, actualResourceRequirements);
    }

    [Test]
    public void Name_ShouldReturnFlammableFuel()
    {
        // Arrange
        var expectedName = "Flammable Fuel";

        // Act
        var actualName = flammableFuelReceipt.Name;

        // Assert
        Assert.AreEqual(expectedName, actualName);
    }

    [Test]
    public void AmmoType_ShouldReturnFuel()
    {
        // Arrange
        var expectedAmmoType = AmmoType.Fuel;

        // Act
        var actualAmmoType = flammableFuelReceipt.AmmoType;

        // Assert
        Assert.AreEqual(expectedAmmoType, actualAmmoType);
    }
}
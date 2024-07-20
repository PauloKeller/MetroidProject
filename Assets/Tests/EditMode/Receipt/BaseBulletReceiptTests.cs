using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class BaseAmmoReceiptTests
{
    private BaseAmmoReceipt baseAmmoReceipt;

    [SetUp]
    public void SetUp()
    {
        baseAmmoReceipt = new BaseAmmoReceipt();
    }

    [Test]
    public void ResourceRequirements_ShouldContainAllResourceTypes_WithZeroValues()
    {
        // Arrange
        var expectedResourceRequirements = new Dictionary<ResourceType, int>
        {
            { ResourceType.Metal, 0 },
            { ResourceType.Flammable, 0 },
            { ResourceType.Cryogenic, 0 },
            { ResourceType.Chemical, 0 },
            { ResourceType.Energy, 0 },
            { ResourceType.Nuclear, 0 }
        };

        // Act
        var actualResourceRequirements = baseAmmoReceipt.ResourceRequirements;

        // Assert
        CollectionAssert.AreEquivalent(expectedResourceRequirements, actualResourceRequirements);
    }

    [Test]
    public void Name_ShouldReturnCorrectValue()
    {
        // Arrange
        var expectedName = "Receipt Name";

        // Act
        var actualName = baseAmmoReceipt.Name;

        // Assert
        Assert.AreEqual(expectedName, actualName);
    }

    [Test]
    public void AmmoType_ShouldReturnCorrectValue()
    {
        // Arrange
        var expectedAmmoType = AmmoType.Bullet;

        // Act
        var actualAmmoType = baseAmmoReceipt.AmmoType;

        // Assert
        Assert.AreEqual(expectedAmmoType, actualAmmoType);
    }
}
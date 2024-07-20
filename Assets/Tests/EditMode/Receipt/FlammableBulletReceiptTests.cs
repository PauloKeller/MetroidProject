using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class FlammableBulletReceiptTests
{
    private MetalBulletReceipt mockBaseReceipt;
    private FlammableBulletReceipt flammableBulletReceipt;

    [SetUp]
    public void SetUp()
    {
        // Mock the base receipt
        mockBaseReceipt = new MetalBulletReceipt(new BaseAmmoReceipt());

        // Initialize the FlammableBulletReceipt with the mock base receipt
        flammableBulletReceipt = new FlammableBulletReceipt(mockBaseReceipt);
    }

    [Test]
    public void ResourceRequirements_ShouldReturnUpdatedValues()
    {
        // Arrange
        var expectedResourceRequirements = new Dictionary<ResourceType, int>
        {
            { ResourceType.Metal, 2 }, // base: 2 + 1
            { ResourceType.Flammable, 2 }, // base: 1 + 2
            { ResourceType.Cryogenic, 0 },
            { ResourceType.Chemical, 0 },
            { ResourceType.Energy, 0 },
            { ResourceType.Nuclear, 0 }
        };

        // Act
        var actualResourceRequirements = flammableBulletReceipt.ResourceRequirements;

        // Assert
        CollectionAssert.AreEquivalent(expectedResourceRequirements, actualResourceRequirements);
    }

    [Test]
    public void Name_ShouldReturnFlameBullet()
    {
        // Arrange
        var expectedName = "Flame Bullet";

        // Act
        var actualName = flammableBulletReceipt.Name;

        // Assert
        Assert.AreEqual(expectedName, actualName);
    }

    [Test]
    public void AmmoType_ShouldReturnFlameBullet()
    {
        // Arrange
        var expectedAmmoType = AmmoType.FlameBullet;

        // Act
        var actualAmmoType = flammableBulletReceipt.AmmoType;

        // Assert
        Assert.AreEqual(expectedAmmoType, actualAmmoType);
    }
}
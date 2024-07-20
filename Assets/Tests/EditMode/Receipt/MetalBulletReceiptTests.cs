using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class MetalBulletReceiptTests
{
    private MetalBulletReceipt metalBulletReceipt;

    [SetUp]
    public void SetUp()
    {
        // Initialize the MetalBulletReceipt with a BaseAmmoReceipt
        metalBulletReceipt = new MetalBulletReceipt(new BaseAmmoReceipt());
    }

    [Test]
    public void ResourceRequirements_ShouldReturnUpdatedValues()
    {
        // Arrange
        var expectedResourceRequirements = new Dictionary<ResourceType, int>
        {
            { ResourceType.Metal, 1 }, // base: 0 + 1
            { ResourceType.Flammable, 0 },
            { ResourceType.Cryogenic, 0 },
            { ResourceType.Chemical, 0 },
            { ResourceType.Energy, 0 },
            { ResourceType.Nuclear, 0 }
        };

        // Act
        var actualResourceRequirements = metalBulletReceipt.ResourceRequirements;

        // Assert
        CollectionAssert.AreEquivalent(expectedResourceRequirements, actualResourceRequirements);
    }

    [Test]
    public void Name_ShouldReturnBullet()
    {
        // Arrange
        var expectedName = "Bullet";

        // Act
        var actualName = metalBulletReceipt.Name;

        // Assert
        Assert.AreEqual(expectedName, actualName);
    }

    [Test]
    public void AmmoType_ShouldReturnBullet()
    {
        // Arrange
        var expectedAmmoType = AmmoType.Bullet;

        // Act
        var actualAmmoType = metalBulletReceipt.AmmoType;

        // Assert
        Assert.AreEqual(expectedAmmoType, actualAmmoType);
    }
}
using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class NuclearMissileReceiptTests
{
    private NuclearMissileReceipt nuclearMissileReceipt;

    [SetUp]
    public void SetUp()
    {
        // Initialize NuclearMissileReceipt with BaseAmmoReceipt as the base
        nuclearMissileReceipt = new NuclearMissileReceipt(new BaseAmmoReceipt());
    }

    [Test]
    public void ResourceRequirements_ShouldReturnUpdatedValues()
    {
        // Arrange
        var expectedResourceRequirements = new Dictionary<ResourceType, int>
        {
            { ResourceType.Metal, 2 },        // base: 0 + 2
            { ResourceType.Flammable, 3 },    // base: 0 + 3
            { ResourceType.Cryogenic, 0 },    // base: 0
            { ResourceType.Chemical, 0 },     // base: 0
            { ResourceType.Energy, 5 },       // base: 0 + 5
            { ResourceType.Nuclear, 7 }       // base: 0 + 7
        };

        // Act
        var actualResourceRequirements = nuclearMissileReceipt.ResourceRequirements;

        // Assert
        CollectionAssert.AreEquivalent(expectedResourceRequirements, actualResourceRequirements);
    }

    [Test]
    public void Name_ShouldReturnNuclearMissile()
    {
        // Arrange
        var expectedName = "Nuclear Missile";

        // Act
        var actualName = nuclearMissileReceipt.Name;

        // Assert
        Assert.AreEqual(expectedName, actualName);
    }

    [Test]
    public void AmmoType_ShouldReturnNuclearMissile()
    {
        // Arrange
        var expectedAmmoType = AmmoType.NuclearMissile;

        // Act
        var actualAmmoType = nuclearMissileReceipt.AmmoType;

        // Assert
        Assert.AreEqual(expectedAmmoType, actualAmmoType);
    }
}
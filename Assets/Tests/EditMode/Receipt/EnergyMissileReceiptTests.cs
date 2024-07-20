using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class EnergyMissileReceiptTests
{
    private EnergyMissileReceipt energyMissileReceipt;

    [SetUp]
    public void SetUp()
    {
        // Initialize EnergyMissileReceipt with NuclearMissileReceipt as the base
        energyMissileReceipt = new EnergyMissileReceipt(new NuclearMissileReceipt(new BaseAmmoReceipt()));
    }

    [Test]
    public void ResourceRequirements_ShouldReturnUpdatedValues()
    {
        // Arrange
        var expectedResourceRequirements = new Dictionary<ResourceType, int>
        {
            { ResourceType.Metal, 4 },        // base: 2 + 2
            { ResourceType.Flammable, 3 },    // base: 3 (unchanged from NuclearMissile)
            { ResourceType.Cryogenic, 0 },    // base: 0 (unchanged from NuclearMissile)
            { ResourceType.Chemical, 0 },     // base: 0 (unchanged from NuclearMissile)
            { ResourceType.Energy, 10 },      // base: 5 + 5
            { ResourceType.Nuclear, 9 }       // base: 7 + 2
        };

        // Act
        var actualResourceRequirements = energyMissileReceipt.ResourceRequirements;

        // Assert
        CollectionAssert.AreEquivalent(expectedResourceRequirements, actualResourceRequirements);
    }

    [Test]
    public void Name_ShouldReturnEnergyMissile()
    {
        // Arrange
        var expectedName = "Energy Missile";

        // Act
        var actualName = energyMissileReceipt.Name;

        // Assert
        Assert.AreEqual(expectedName, actualName);
    }

    [Test]
    public void AmmoType_ShouldReturnEnergyMissile()
    {
        // Arrange
        var expectedAmmoType = AmmoType.EnergyMissile;

        // Act
        var actualAmmoType = energyMissileReceipt.AmmoType;

        // Assert
        Assert.AreEqual(expectedAmmoType, actualAmmoType);
    }
}
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[TestFixture]
public class EnergyCellReceiptTests
{
    private EnergyCellReceipt energyCellReceipt;

    [SetUp]
    public void SetUp()
    {
        // Initialize the EnergyCellReceipt with BaseAmmoReceipt
        energyCellReceipt = new EnergyCellReceipt(new BaseAmmoReceipt());
    }

    [Test]
    public void ResourceRequirements_ShouldReturnUpdatedValues()
    {
        // Arrange
        var expectedResourceRequirements = new Dictionary<ResourceType, int>
        {
            { ResourceType.Metal, 2 },       // base: 0 + 2
            { ResourceType.Flammable, 0 },   // base: 0
            { ResourceType.Cryogenic, 0 },   // base: 0
            { ResourceType.Chemical, 0 },    // base: 0
            { ResourceType.Energy, 3 },      // base: 0 + 3
            { ResourceType.Nuclear, 0 }      // base: 0
        };

        // Act
        var actualResourceRequirements = energyCellReceipt.ResourceRequirements;

        // Assert
        CollectionAssert.AreEquivalent(expectedResourceRequirements, actualResourceRequirements);
    }

    [Test]
    public void Name_ShouldReturnEnergyCell()
    {
        // Arrange
        var expectedName = "Energy Cell";

        // Act
        var actualName = energyCellReceipt.Name;

        // Assert
        Assert.AreEqual(expectedName, actualName);
    }

    [Test]
    public void AmmoType_ShouldReturnEnergyCell()
    {
        // Arrange
        var expectedAmmoType = AmmoType.EnergyCell;

        // Act
        var actualAmmoType = energyCellReceipt.AmmoType;

        // Assert
        Assert.AreEqual(expectedAmmoType, actualAmmoType);
    }
}
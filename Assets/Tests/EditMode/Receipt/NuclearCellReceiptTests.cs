using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class NuclearCellReceiptTests
{
    private NuclearCellReceipt nuclearCellReceipt;

    [SetUp]
    public void SetUp()
    {
        // Initialize NuclearCellReceipt with CryogenicCellReceipt as the base
        nuclearCellReceipt = new NuclearCellReceipt(new CryogenicCellReceipt(new EnergyCellReceipt(new BaseAmmoReceipt())));
    }

    [Test]
    public void ResourceRequirements_ShouldReturnUpdatedValues()
    {
        // Arrange
        var expectedResourceRequirements = new Dictionary<ResourceType, int>
        {
            { ResourceType.Metal, 5 },        // base: 4 + 1 + 1
            { ResourceType.Flammable, 0 },    // base: 0
            { ResourceType.Cryogenic, 5 },    // base: 5
            { ResourceType.Chemical, 0 },     // base: 0
            { ResourceType.Energy, 6 },       // base: 5 + 1
            { ResourceType.Nuclear, 5 }       // base: 5
        };

        // Act
        var actualResourceRequirements = nuclearCellReceipt.ResourceRequirements;

        // Assert
        CollectionAssert.AreEquivalent(expectedResourceRequirements, actualResourceRequirements);
    }

    [Test]
    public void Name_ShouldReturnNuclearCell()
    {
        // Arrange
        var expectedName = "Nuclear Cell";

        // Act
        var actualName = nuclearCellReceipt.Name;

        // Assert
        Assert.AreEqual(expectedName, actualName);
    }

    [Test]
    public void AmmoType_ShouldReturnNuclearCell()
    {
        // Arrange
        var expectedAmmoType = AmmoType.NuclearCell;

        // Act
        var actualAmmoType = nuclearCellReceipt.AmmoType;

        // Assert
        Assert.AreEqual(expectedAmmoType, actualAmmoType);
    }
}

using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class CryogenicCellReceiptTests
{
    private CryogenicCellReceipt cryogenicCellReceipt;

    [SetUp]
    public void SetUp()
    {
        // Initialize CryogenicCellReceipt with EnergyCellReceipt as the base
        cryogenicCellReceipt = new CryogenicCellReceipt(new EnergyCellReceipt(new BaseAmmoReceipt()));
    }

    [Test]
    public void ResourceRequirements_ShouldReturnUpdatedValues()
    {
        // Arrange
        var expectedResourceRequirements = new Dictionary<ResourceType, int>
        {
            { ResourceType.Metal, 4 },        // base: 2 + 2
            { ResourceType.Flammable, 0 },    // base: 0
            { ResourceType.Cryogenic, 5 },    // base: 0 + 5
            { ResourceType.Chemical, 0 },     // base: 0
            { ResourceType.Energy, 5 },       // base: 3 + 2
            { ResourceType.Nuclear, 0 }       // base: 0
        };

        // Act
        var actualResourceRequirements = cryogenicCellReceipt.ResourceRequirements;

        // Assert
        CollectionAssert.AreEquivalent(expectedResourceRequirements, actualResourceRequirements);
    }

    [Test]
    public void Name_ShouldReturnCryogenicCell()
    {
        // Arrange
        var expectedName = "Cryogenic Cell";

        // Act
        var actualName = cryogenicCellReceipt.Name;

        // Assert
        Assert.AreEqual(expectedName, actualName);
    }

    [Test]
    public void AmmoType_ShouldReturnCryogenicCell()
    {
        // Arrange
        var expectedAmmoType = AmmoType.CryogenicCell;

        // Act
        var actualAmmoType = cryogenicCellReceipt.AmmoType;

        // Assert
        Assert.AreEqual(expectedAmmoType, actualAmmoType);
    }
}
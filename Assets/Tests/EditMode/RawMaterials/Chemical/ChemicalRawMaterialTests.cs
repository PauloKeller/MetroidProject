using NUnit.Framework;

[TestFixture]
public class ChemicalRawMaterialTests
{
    private ChemicalResource chemicalRawMaterial;

    [SetUp]
    public void SetUp()
    {
        chemicalRawMaterial = new ChemicalResource();
    }

    [Test]
    public void Weight_ShouldReturnExpectedValue()
    {
        // Arrange
        float expectedWeight = 7f;

        // Act
        float actualWeight = chemicalRawMaterial.Weight;

        // Assert
        Assert.AreEqual(expectedWeight, actualWeight);
    }

    [Test]
    public void MaxStack_ShouldReturnExpectedValue()
    {
        // Arrange
        int expectedMaxStack = 9999;

        // Act
        int actualMaxStack = chemicalRawMaterial.MaxStack;

        // Assert
        Assert.AreEqual(expectedMaxStack, actualMaxStack);
    }

    [Test]
    public void Description_ShouldReturnExpectedValue()
    {
        // Arrange
        string expectedDescription = "";

        // Act
        string actualDescription = chemicalRawMaterial.Description;

        // Assert
        Assert.AreEqual(expectedDescription, actualDescription);
    }
}
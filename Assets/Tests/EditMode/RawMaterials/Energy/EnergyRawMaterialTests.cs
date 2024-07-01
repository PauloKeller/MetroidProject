using NUnit.Framework;

[TestFixture]
public class EnergyRawMaterialTests
{
    private EnergyRawMaterial energyRawMaterial;

    [SetUp]
    public void SetUp()
    {
        energyRawMaterial = new EnergyRawMaterial();
    }

    [Test]
    public void Weight_ShouldReturnExpectedValue()
    {
        // Arrange
        float expectedWeight = 4f;

        // Act
        float actualWeight = energyRawMaterial.Weight;

        // Assert
        Assert.AreEqual(expectedWeight, actualWeight);
    }

    [Test]
    public void MaxStack_ShouldReturnExpectedValue()
    {
        // Arrange
        int expectedMaxStack = 9999;

        // Act
        int actualMaxStack = energyRawMaterial.MaxStack;

        // Assert
        Assert.AreEqual(expectedMaxStack, actualMaxStack);
    }

    [Test]
    public void Description_ShouldReturnExpectedValue()
    {
        // Arrange
        string expectedDescription = "";

        // Act
        string actualDescription = energyRawMaterial.Description;

        // Assert
        Assert.AreEqual(expectedDescription, actualDescription);
    }
}
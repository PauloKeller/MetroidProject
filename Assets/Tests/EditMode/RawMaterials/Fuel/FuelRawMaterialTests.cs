using NUnit.Framework;

[TestFixture]
public class FuelRawMaterialTests
{
    private FuelRawMaterial fuelRawMaterial;

    [SetUp]
    public void SetUp()
    {
        fuelRawMaterial = new FuelRawMaterial();
    }

    [Test]
    public void Weight_ShouldReturnExpectedValue()
    {
        // Arrange
        float expectedWeight = 1f;

        // Act
        float actualWeight = fuelRawMaterial.Weight;

        // Assert
        Assert.AreEqual(expectedWeight, actualWeight);
    }

    [Test]
    public void MaxStack_ShouldReturnExpectedValue()
    {
        // Arrange
        int expectedMaxStack = 9999;

        // Act
        int actualMaxStack = fuelRawMaterial.MaxStack;

        // Assert
        Assert.AreEqual(expectedMaxStack, actualMaxStack);
    }

    [Test]
    public void Description_ShouldReturnExpectedValue()
    {
        // Arrange
        string expectedDescription = "";

        // Act
        string actualDescription = fuelRawMaterial.Description;

        // Assert
        Assert.AreEqual(expectedDescription, actualDescription);
    }
}
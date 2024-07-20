using NUnit.Framework;

[TestFixture]
public class EnergyResourceTests
{
    private EnergyResource energyResource;

    [SetUp]
    public void SetUp()
    {
        energyResource = new EnergyResource();
    }

    [Test]
    public void Weight_ShouldReturnExpectedValue()
    {
        // Arrange
        float expectedWeight = 4f;

        // Act
        float actualWeight = energyResource.Weight;

        // Assert
        Assert.AreEqual(expectedWeight, actualWeight);
    }

    [Test]
    public void MaxStack_ShouldReturnExpectedValue()
    {
        // Arrange
        int expectedMaxStack = 9999;

        // Act
        int actualMaxStack = energyResource.MaxStack;

        // Assert
        Assert.AreEqual(expectedMaxStack, actualMaxStack);
    }

    [Test]
    public void Description_ShouldReturnExpectedValue()
    {
        // Arrange
        string expectedDescription = "";

        // Act
        string actualDescription = energyResource.Description;

        // Assert
        Assert.AreEqual(expectedDescription, actualDescription);
    }

    [Test]
    public void Type_ReturnsExpectedValue()
    {
        // Act
        var type = energyResource.Type;

        // Assert
        Assert.AreEqual(ResourceType.Energy, type);
    }
}
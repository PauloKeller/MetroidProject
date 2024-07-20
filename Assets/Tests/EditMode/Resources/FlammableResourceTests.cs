using NUnit.Framework;

[TestFixture]
public class FlammableResourceTests
{
    private FlammableResource flammableResource;

    [SetUp]
    public void SetUp()
    {
        flammableResource = new FlammableResource();
    }

    [Test]
    public void Weight_ShouldReturnExpectedValue()
    {
        // Arrange
        float expectedWeight = 1f;

        // Act
        float actualWeight = flammableResource.Weight;

        // Assert
        Assert.AreEqual(expectedWeight, actualWeight);
    }

    [Test]
    public void MaxStack_ShouldReturnExpectedValue()
    {
        // Arrange
        int expectedMaxStack = 9999;

        // Act
        int actualMaxStack = flammableResource.MaxStack;

        // Assert
        Assert.AreEqual(expectedMaxStack, actualMaxStack);
    }

    [Test]
    public void Description_ShouldReturnExpectedValue()
    {
        // Arrange
        string expectedDescription = "";

        // Act
        string actualDescription = flammableResource.Description;

        // Assert
        Assert.AreEqual(expectedDescription, actualDescription);
    }

    [Test]
    public void Type_ReturnsExpectedValue()
    {
        // Act
        var type = flammableResource.Type;

        // Assert
        Assert.AreEqual(ResourceType.Flammable, type);
    }
}
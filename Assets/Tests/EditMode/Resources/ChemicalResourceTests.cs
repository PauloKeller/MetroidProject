using NUnit.Framework;

[TestFixture]
public class ChemicalResourceTests
{
    private ChemicalResource chemicalResource;

    [SetUp]
    public void SetUp()
    {
        chemicalResource = new ChemicalResource();
    }

    [Test]
    public void Weight_ShouldReturnExpectedValue()
    {
        // Arrange
        float expectedWeight = 7f;

        // Act
        float actualWeight = chemicalResource.Weight;

        // Assert
        Assert.AreEqual(expectedWeight, actualWeight);
    }

    [Test]
    public void MaxStack_ShouldReturnExpectedValue()
    {
        // Arrange
        int expectedMaxStack = 9999;

        // Act
        int actualMaxStack = chemicalResource.MaxStack;

        // Assert
        Assert.AreEqual(expectedMaxStack, actualMaxStack);
    }

    [Test]
    public void Description_ShouldReturnExpectedValue()
    {
        // Arrange
        string expectedDescription = "";

        // Act
        string actualDescription = chemicalResource.Description;

        // Assert
        Assert.AreEqual(expectedDescription, actualDescription);
    }

    [Test]
    public void Type_ReturnsExpectedValue()
    {
        // Act
        var type = chemicalResource.Type;

        // Assert
        Assert.AreEqual(ResourceType.Chemical, type);
    }
}
using NUnit.Framework;

[TestFixture]
public class MetalResourceTests
{
    private MetalResource metalResource;

    [SetUp]
    public void SetUp()
    {
        metalResource = new MetalResource();
    }

    [Test]
    public void Weight_ShouldReturnExpectedValue()
    {
        // Arrange
        float expectedWeight = 1.5f;

        // Act
        float actualWeight = metalResource.Weight;

        // Assert
        Assert.AreEqual(expectedWeight, actualWeight);
    }

    [Test]
    public void MaxStack_ShouldReturnExpectedValue()
    {
        // Arrange
        int expectedMaxStack = 9999;

        // Act
        int actualMaxStack = metalResource.MaxStack;

        // Assert
        Assert.AreEqual(expectedMaxStack, actualMaxStack);
    }

    [Test]
    public void Description_ShouldReturnExpectedValue()
    {
        // Arrange
        string expectedDescription = "Iron ores are rocks and minerals from which metallic iron can be economically extracted.";

        // Act
        string actualDescription = metalResource.Description;

        // Assert
        Assert.AreEqual(expectedDescription, actualDescription);
    }
}
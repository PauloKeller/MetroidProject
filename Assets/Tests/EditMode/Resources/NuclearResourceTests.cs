using NUnit.Framework;

[TestFixture]
public class NuclearResourceTests
{
    private NuclearResource nuclearResource;

    [SetUp]
    public void SetUp()
    {
        nuclearResource = new NuclearResource();
    }

    [Test]
    public void Weight_ShouldReturnExpectedValue()
    {
        // Arrange
        float expectedWeight = 10f;

        // Act
        float actualWeight = nuclearResource.Weight;

        // Assert
        Assert.AreEqual(expectedWeight, actualWeight);
    }

    [Test]
    public void MaxStack_ShouldReturnExpectedValue()
    {
        // Arrange
        int expectedMaxStack = 9999;

        // Act
        int actualMaxStack = nuclearResource.MaxStack;

        // Assert
        Assert.AreEqual(expectedMaxStack, actualMaxStack);
    }

    [Test]
    public void Description_ShouldReturnExpectedValue()
    {
        // Arrange
        string expectedDescription = "Iron ores are rocks and minerals from which metallic iron can be economically extracted.";

        // Act
        string actualDescription = nuclearResource.Description;

        // Assert
        Assert.AreEqual(expectedDescription, actualDescription);
    }
}
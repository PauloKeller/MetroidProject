using NUnit.Framework;

[TestFixture]
public class RadioactiveRawMaterialTests
{
    private RadioactiveRawMaterial radioactiveRawMaterial;

    [SetUp]
    public void SetUp()
    {
        radioactiveRawMaterial = new RadioactiveRawMaterial();
    }

    [Test]
    public void Weight_ShouldReturnExpectedValue()
    {
        // Arrange
        float expectedWeight = 10f;

        // Act
        float actualWeight = radioactiveRawMaterial.Weight;

        // Assert
        Assert.AreEqual(expectedWeight, actualWeight);
    }

    [Test]
    public void MaxStack_ShouldReturnExpectedValue()
    {
        // Arrange
        int expectedMaxStack = 9999;

        // Act
        int actualMaxStack = radioactiveRawMaterial.MaxStack;

        // Assert
        Assert.AreEqual(expectedMaxStack, actualMaxStack);
    }

    [Test]
    public void Description_ShouldReturnExpectedValue()
    {
        // Arrange
        string expectedDescription = "Iron ores are rocks and minerals from which metallic iron can be economically extracted.";

        // Act
        string actualDescription = radioactiveRawMaterial.Description;

        // Assert
        Assert.AreEqual(expectedDescription, actualDescription);
    }
}
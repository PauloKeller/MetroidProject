using NUnit.Framework;
using System;

[TestFixture]
public class ResourceFactoryTests
{
    [Test]
    public void GetResource_WithKnownType_ReturnsCorrectResource()
    {
        // Arrange
        var expected = new MetalResource();

        // Act
        var result = ResourceFactory.GetResource(ResourceType.Metal);

        // Assert
        Assert.AreEqual(expected.GetType(), result.GetType());
    }

    [Test]
    public void GetResource_WithUnknownType_ThrowsArgumentException()
    {
        // Arrange
        var unknownType = (ResourceType)999; // Assuming 999 is not a valid ResourceType

        // Act & Assert
        Assert.Throws<ArgumentException>(() => ResourceFactory.GetResource(unknownType));
    }

    [Test]
    public void GetResource_WithAllKnownTypes_ReturnsNonNullResource()
    {
        // Arrange
        var resourceTypes = Enum.GetValues(typeof(ResourceType));

        // Act & Assert
        foreach (ResourceType type in resourceTypes)
        {
            if (type != (ResourceType)999) // Exclude invalid types
            {
                var result = ResourceFactory.GetResource(type);
                Assert.IsNotNull(result);
            }
        }
    }
}
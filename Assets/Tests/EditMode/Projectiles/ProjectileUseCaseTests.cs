using NUnit.Framework;
using UnityEngine;

public class ProjectileUseCaseTest 
{
    private IProjectileUseCase sut;

    [SetUp]
    public void SetUp()
    {
        sut = new ProjectileUseCase(initialDistance: new Vector2());
    }

    [Test]
    public void CalculateTravelDistance_ReturnsValidDistance()
    {
        // Arrange
        var mock = new GameObject().transform; // Creating a dummy transform for testing
        mock.transform.Translate(new Vector2(10, 0));

        // Act
        var distance = sut.CalculateTravelDistance(mock);

        // Assert
        Assert.AreEqual(10f, distance); // Asserting against the mock implementation
    }
}

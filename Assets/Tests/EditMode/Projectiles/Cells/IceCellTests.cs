using NUnit.Framework;

public class IceCellTests
{
    [Test]
    public void ProjectileType_ReturnsCryogenic()
    {
        // Arrange
        IProjectile baseProjectile = new EnergyCell(); // Using EnergyCell as the base projectile for testing
        IceCell iceCell = new IceCell(baseProjectile);

        // Act
        ProjectileType type = iceCell.ProjectileType;

        // Assert
        Assert.AreEqual(ProjectileType.Cryogenic, type);
    }
}
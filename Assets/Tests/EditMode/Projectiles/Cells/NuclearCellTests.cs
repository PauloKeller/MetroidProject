using NUnit.Framework;

public class NuclearCellTests
{
    [Test]
    public void ProjectileType_ReturnsNuclear()
    {
        // Arrange
        IProjectile baseProjectile = new EnergyCell(); // Using EnergyCell as the base projectile for testing
        NuclearCell nuclearCell = new NuclearCell(baseProjectile);

        // Act
        ProjectileType type = nuclearCell.ProjectileType;

        // Assert
        Assert.AreEqual(ProjectileType.Nuclear, type);
    }
}
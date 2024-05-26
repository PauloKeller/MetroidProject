using NUnit.Framework;

public class EnergyCellTests
{
    [Test]
    public void Damage_ReturnsValidDamage()
    {
        // Arrange
        EnergyCell energyCell = new EnergyCell();

        // Act
        int damage = energyCell.Damage;

        // Assert
        Assert.AreEqual(30, damage);
    }

    [Test]
    public void Speed_ReturnsValidSpeed()
    {
        // Arrange
        EnergyCell energyCell = new EnergyCell();

        // Act
        float speed = energyCell.Speed;

        // Assert
        Assert.AreEqual(17f, speed);
    }

    [Test]
    public void IsPiercing_ReturnsTrue()
    {
        // Arrange
        EnergyCell energyCell = new EnergyCell();

        // Act
        bool isPiercing = energyCell.IsPiercing;

        // Assert
        Assert.IsTrue(isPiercing);
    }

    [Test]
    public void ProjectileType_ReturnsValidType()
    {
        // Arrange
        EnergyCell energyCell = new EnergyCell();

        // Act
        ProjectileType type = energyCell.ProjectileType;

        // Assert
        Assert.AreEqual(ProjectileType.Electrical, type);
    }
}
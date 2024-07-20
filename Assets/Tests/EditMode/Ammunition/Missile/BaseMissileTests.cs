using NUnit.Framework;

[TestFixture]
public class BaseMissileTests
{
    private BaseMissile baseMissile;

    [SetUp]
    public void Setup()
    {
        baseMissile = new BaseMissile();
    }

    [Test]
    public void Damage_ReturnsExpectedValue()
    {
        // Act
        var damage = baseMissile.Damage;

        // Assert
        Assert.AreEqual(50, damage);
    }

    [Test]
    public void ExplosionRadius_ReturnsExpectedValue()
    {
        // Act
        var explosionRadius = baseMissile.ExplosionRadius;

        // Assert
        Assert.AreEqual(10f, explosionRadius);
    }

    [Test]
    public void ExplosionSpeed_ReturnsExpectedValue()
    {
        // Act
        var explosionSpeed = baseMissile.ExplosionSpeed;

        // Assert
        Assert.AreEqual(15f, explosionSpeed);
    }

    [Test]
    public void ExecutionPercentage_ReturnsExpectedValue()
    {
        // Act
        var executionPercentage = baseMissile.ExecutionPercentage;

        // Assert
        Assert.AreEqual(5f, executionPercentage);
    }

    [Test]
    public void Name_ReturnsExpectedValue()
    {
        // Act
        var name = baseMissile.Name;

        // Assert
        Assert.AreEqual("Missile Name", name);
    }

    [Test]
    public void Type_ReturnsExpectedValue()
    {
        // Act
        var type = baseMissile.Type;

        // Assert
        Assert.AreEqual(AmmoType.NuclearMissile, type);
    }
}
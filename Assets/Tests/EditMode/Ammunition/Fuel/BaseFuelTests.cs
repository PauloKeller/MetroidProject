using NUnit.Framework;

[TestFixture]
public class BaseFuelTests
{
    private BaseFuel baseFuel;

    [SetUp]
    public void Setup()
    {
        baseFuel = new BaseFuel();
    }

    [Test]
    public void DebuffDuration_ReturnsExpectedValue()
    {
        // Act
        var debuffDuration = baseFuel.DebuffDuration;

        // Assert
        Assert.AreEqual(5.0f, debuffDuration);
    }

    [Test]
    public void DamageOverTimer_ReturnsExpectedValue()
    {
        // Act
        var damageOverTimer = baseFuel.DamageOverTimer;

        // Assert
        Assert.AreEqual(5, damageOverTimer);
    }

    [Test]
    public void Name_ReturnsExpectedValue()
    {
        // Act
        var name = baseFuel.Name;

        // Assert
        Assert.AreEqual("Fuel name", name);
    }

    [Test]
    public void Type_ReturnsExpectedValue()
    {
        // Act
        var type = baseFuel.Type;

        // Assert
        Assert.AreEqual(AmmoType.Fuel, type);
    }
}
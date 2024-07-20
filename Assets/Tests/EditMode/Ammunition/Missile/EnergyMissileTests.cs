using NUnit.Framework;

public class EnergyMissileTests
{
    private EnergyMissile energyMissile;
    private NuclearMissile nuclearMissile;

    [SetUp]
    public void Setup()
    {
        nuclearMissile = new NuclearMissile(new BaseMissile());
        energyMissile = new EnergyMissile(nuclearMissile);
    }

    [Test]
    public void Type_ReturnsExpectedValue()
    {
        // Act
        var type = energyMissile.Type;

        // Assert
        Assert.AreEqual(AmmoType.EnergyMissile, type);
    }

    [Test]
    public void Name_ReturnsExpectedValue()
    {
        // Act
        var name = energyMissile.Name;

        // Assert
        Assert.AreEqual("EPM Nuke", name);
    }
}
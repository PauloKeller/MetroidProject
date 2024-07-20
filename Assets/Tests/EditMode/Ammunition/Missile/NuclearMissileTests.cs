using NUnit.Framework;

[TestFixture]
public class NuclearMissileTests
{
    private NuclearMissile nuclearMissile;
    private BaseMissile baseMissile;

    [SetUp]
    public void Setup()
    {
        baseMissile = new BaseMissile();
        nuclearMissile = new NuclearMissile(baseMissile);
    }

    [Test]
    public void Type_ReturnsExpectedValue()
    {
        // Act
        var type = nuclearMissile.Type;

        // Assert
        Assert.AreEqual(AmmoType.NuclearMissile, type);
    }

    [Test]
    public void Name_ReturnsExpectedValue()
    {
        // Act
        var name = nuclearMissile.Name;

        // Assert
        Assert.AreEqual("Nuke", name);
    }
}
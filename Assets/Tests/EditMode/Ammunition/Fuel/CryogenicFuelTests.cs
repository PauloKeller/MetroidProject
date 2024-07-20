using NUnit.Framework;

[TestFixture]
public class CryogenicFuelTests
{
    private CryogenicFuel cryogenicFuel;
    private BaseFuel baseFuel;

    [SetUp]
    public void Setup()
    {
        baseFuel = new BaseFuel();
        cryogenicFuel = new CryogenicFuel(baseFuel);
    }

    [Test]
    public void Type_ReturnsExpectedValue()
    {
        // Act
        var type = cryogenicFuel.Type;

        // Assert
        Assert.AreEqual(AmmoType.CryogenicFuel, type);
    }

    [Test]
    public void Name_ReturnsExpectedValue()
    {
        // Act
        var name = cryogenicFuel.Name;

        // Assert
        Assert.AreEqual("Frozen Fuel", name);
    }
}
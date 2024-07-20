using NUnit.Framework;

[TestFixture]
public class FlammableFuelTests
{
    private FlammableFuel flammableFuel;
    private BaseFuel baseFuel;

    [SetUp]
    public void Setup()
    {
        baseFuel = new BaseFuel();
        flammableFuel = new FlammableFuel(baseFuel);
    }

    [Test]
    public void Name_ReturnsExpectedValue()
    {
        // Act
        var name = flammableFuel.Name;

        // Assert
        Assert.AreEqual("Fuel", name);
    }

    [Test]
    public void Type_ReturnsExpectedValue()
    {
        // Act
        var type = flammableFuel.Type;

        // Assert
        Assert.AreEqual(AmmoType.Fuel, type);
    }
}
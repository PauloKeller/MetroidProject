using NUnit.Framework;

[TestFixture]
public class ChemicalFuelTests
{
    private ChemicalFuel chemicalFuel;
    private BaseFuel baseFuel;

    [SetUp]
    public void Setup()
    {
        baseFuel = new BaseFuel();
        chemicalFuel = new ChemicalFuel(baseFuel);
    }

    [Test]
    public void Type_ReturnsExpectedValue()
    {
        // Act
        var type = chemicalFuel.Type;

        // Assert
        Assert.AreEqual(AmmoType.ChemicalFuel, type);
    }

    [Test]
    public void Name_ReturnsExpectedValue()
    {
        // Act
        var name = chemicalFuel.Name;

        // Assert
        Assert.AreEqual("Toxic Fuel", name);
    }
}
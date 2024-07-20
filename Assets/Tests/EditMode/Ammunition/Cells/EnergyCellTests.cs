using NUnit.Framework;

[TestFixture]
public class EnergyCellTests
{
    private EnergyCell energyCell;
    private BaseCell baseCell;

    [SetUp]
    public void Setup()
    {
        baseCell = new BaseCell();
        energyCell = new EnergyCell(baseCell);
    }

    [Test]
    public void PiercingCount_ReturnsExpectedValue()
    {
        // Act
        var piercingCount = energyCell.PiercingCount;

        // Assert
        Assert.AreEqual(2, piercingCount);
    }

    [Test]
    public void Damage_ReturnsExpectedValue()
    {
        // Act
        var damage = energyCell.Damage;

        // Assert
        Assert.AreEqual(10, damage);
    }

    [Test]
    public void Type_ReturnsExpectedValue()
    {
        // Act
        var type = energyCell.Type;

        // Assert
        Assert.AreEqual(AmmoType.EnergyCell, type);
    }

    [Test]
    public void Name_ReturnsExpectedValue()
    {
        // Act
        var name = energyCell.Name;

        // Assert
        Assert.AreEqual("Cell", name);
    }
}
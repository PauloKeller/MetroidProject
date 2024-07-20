using NUnit.Framework;

[TestFixture]
public class CryogenicCellTests
{
    private CryogenicCell cryogenicCell;
    private EnergyCell energyCell;

    [SetUp]
    public void Setup()
    {
        energyCell = new EnergyCell(new BaseCell());
        cryogenicCell = new CryogenicCell(energyCell);
    }

    [Test]
    public void PiercingCount_ReturnsExpectedValue()
    {
        // Act
        var piercingCount = cryogenicCell.PiercingCount;

        // Assert
        Assert.AreEqual(2, piercingCount);
    }

    [Test]
    public void Damage_ReturnsExpectedValue()
    {
        // Act
        var damage = cryogenicCell.Damage;

        // Assert
        Assert.AreEqual(10, damage);
    }

    [Test]
    public void Type_ReturnsExpectedValue()
    {
        // Act
        var type = cryogenicCell.Type;

        // Assert
        Assert.AreEqual(AmmoType.CryogenicCell, type);
    }

    [Test]
    public void Name_ReturnsExpectedValue()
    {
        // Act
        var name = cryogenicCell.Name;

        // Assert
        Assert.AreEqual("Frozen Cell", name);
    }
}
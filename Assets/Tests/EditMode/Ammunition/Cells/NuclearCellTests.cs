using NUnit.Framework;

[TestFixture]
public class NuclearCellTests
{
    private NuclearCell nuclearCell;
    private CryogenicCell cryogenicCell;

    [SetUp]
    public void Setup()
    {
        cryogenicCell = new CryogenicCell(new BaseCell());
        nuclearCell = new NuclearCell(cryogenicCell);
    }

    [Test]
    public void PiercingCount_ReturnsExpectedValue()
    {
        // Act
        var piercingCount = nuclearCell.PiercingCount;

        // Assert
        Assert.AreEqual(2, piercingCount);
    }

    [Test]
    public void Damage_ReturnsExpectedValue()
    {
        // Act
        var damage = nuclearCell.Damage;

        // Assert
        Assert.AreEqual(10, damage);
    }

    [Test]
    public void Type_ReturnsExpectedValue()
    {
        // Act
        var type = nuclearCell.Type;

        // Assert
        Assert.AreEqual(AmmoType.NuclearCell, type);
    }

    [Test]
    public void Name_ReturnsExpectedValue()
    {
        // Act
        var name = nuclearCell.Name;

        // Assert
        Assert.AreEqual("Atomic Cell", name);
    }
}
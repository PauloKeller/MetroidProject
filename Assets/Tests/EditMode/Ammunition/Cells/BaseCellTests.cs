using NUnit.Framework;

[TestFixture]
public class BaseCellTests
{
    private BaseCell _baseCell;

    [SetUp]
    public void Setup()
    {
        _baseCell = new BaseCell();
    }

    [Test]
    public void PiercingCount_ReturnsExpectedValue()
    {
        // Act
        var piercingCount = _baseCell.PiercingCount;

        // Assert
        Assert.AreEqual(2, piercingCount);
    }

    [Test]
    public void Damage_ReturnsExpectedValue()
    {
        // Act
        var damage = _baseCell.Damage;

        // Assert
        Assert.AreEqual(10, damage);
    }

    [Test]
    public void Name_ReturnsExpectedValue()
    {
        // Act
        var name = _baseCell.Name;

        // Assert
        Assert.AreEqual("Cell Name", name);
    }

    [Test]
    public void Type_ReturnsExpectedValue()
    {
        // Act
        var type = _baseCell.Type;

        // Assert
        Assert.AreEqual(AmmoType.EnergyCell, type);
    }
}
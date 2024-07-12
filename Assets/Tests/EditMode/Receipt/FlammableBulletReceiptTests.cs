using NUnit.Framework;

[TestFixture]
public class FlammableBulletReceiptTests
{
    private FlammableBulletReceipt flammableBulletReceipt;

    [SetUp]
    public void SetUp()
    {
        var baseBulletReceipt = new BaseBulletReceipt();
        flammableBulletReceipt = new FlammableBulletReceipt(baseBulletReceipt);
    }

    [Test]
    public void MetalMaterialRequired_ShouldReturnBaseValuePlusOne()
    {
        // Act
        int result = flammableBulletReceipt.MetalMaterialRequired;

        // Assert
        Assert.AreEqual(2, result);
    }

    [Test]
    public void FuelMaterialRequired_ShouldReturnBaseValuePlusTwo()
    {
        // Act
        int result = flammableBulletReceipt.FuelMaterialRequired;

        // Assert
        Assert.AreEqual(2, result);
    }

    [Test]
    public void Name_ShouldReturnCorrectName()
    {
        // Act
        string result = flammableBulletReceipt.Name;

        // Assert
        Assert.AreEqual("Flame Bullet", result);
    }
}
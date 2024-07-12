using NUnit.Framework;

[TestFixture]
public class MetalBulletReceiptTests
{
    private MetalBulletReceipt metalBulletReceipt;

    [SetUp]
    public void SetUp()
    {
        var baseBulletReceipt = new BaseBulletReceipt();
        metalBulletReceipt = new MetalBulletReceipt(baseBulletReceipt);
    }

    [Test]
    public void Name_ShouldReturnCorrectName()
    {
        // Act
        string result = metalBulletReceipt.Name;

        // Assert
        Assert.AreEqual("Bullet", result);
    }

    [Test]
    public void MetalMaterialRequired_ShouldReturnBaseValue()
    {
        // Act
        int result = metalBulletReceipt.MetalMaterialRequired;

        // Assert
        Assert.AreEqual(1, result);
    }

    [Test]
    public void ChemicalMaterialRequired_ShouldReturnBaseValue()
    {
        // Act
        int result = metalBulletReceipt.ChemicalMaterialRequired;

        // Assert
        Assert.AreEqual(0, result);
    }

    [Test]
    public void EnergyMaterialRequired_ShouldReturnBaseValue()
    {
        // Act
        int result = metalBulletReceipt.EnergyMaterialRequired;

        // Assert
        Assert.AreEqual(0, result);
    }

    [Test]
    public void FuelMaterialRequired_ShouldReturnBaseValue()
    {
        // Act
        int result = metalBulletReceipt.FuelMaterialRequired;

        // Assert
        Assert.AreEqual(0, result);
    }

    [Test]
    public void RadioactiveMaterialRequired_ShouldReturnBaseValue()
    {
        // Act
        int result = metalBulletReceipt.RadioactiveMaterialRequired;

        // Assert
        Assert.AreEqual(0, result);
    }
}
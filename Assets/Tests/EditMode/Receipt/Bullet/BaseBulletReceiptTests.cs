using NUnit.Framework;

[TestFixture]
public class BaseBulletReceiptTests
{
    private BaseBulletReceipt receipt;

    [SetUp]
    public void SetUp()
    {
        receipt = new BaseBulletReceipt();
    }

    [Test]
    public void MetalMaterialRequired_ShouldReturn1()
    {
        // Act
        int result = receipt.MetalResourceRequired;

        // Assert
        Assert.AreEqual(1, result);
    }

    [Test]
    public void ChemicalMaterialRequired_ShouldReturn0()
    {
        // Act
        int result = receipt.ChemicalResourceRequired;

        // Assert
        Assert.AreEqual(0, result);
    }

    [Test]
    public void EnergyMaterialRequired_ShouldReturn0()
    {
        // Act
        int result = receipt.EnergyResourceRequired;

        // Assert
        Assert.AreEqual(0, result);
    }

    [Test]
    public void FuelMaterialRequired_ShouldReturn0()
    {
        // Act
        int result = receipt.FlammableResourceRequired;

        // Assert
        Assert.AreEqual(0, result);
    }

    [Test]
    public void RadioactiveMaterialRequired_ShouldReturn0()
    {
        // Act
        int result = receipt.RadioactiveMaterialRequired;

        // Assert
        Assert.AreEqual(0, result);
    }

    [Test]
    public void Name_ShouldReturnCorrectName()
    {
        // Act
        string result = receipt.Name;

        // Assert
        Assert.AreEqual("Ammo Receipt Name", result);
    }
}
using NUnit.Framework;

[TestFixture]
public class BaseFuelReceiptTests
{
    private BaseFuelReceipt baseFuelReceipt;

    [SetUp]
    public void Setup()
    {
        baseFuelReceipt = new BaseFuelReceipt();
    }

    [Test]
    public void MetalResourceRequired_ShouldBe0()
    {
        Assert.AreEqual(0, baseFuelReceipt.MetalResourceRequired);
    }

    [Test]
    public void ChemicalResourceRequired_ShouldBe0()
    {
        Assert.AreEqual(0, baseFuelReceipt.ChemicalResourceRequired);
    }

    [Test]
    public void EnergyResourceRequired_ShouldBe0()
    {
        Assert.AreEqual(0, baseFuelReceipt.EnergyResourceRequired);
    }

    [Test]
    public void FlammableResourceRequired_ShouldBe2()
    {
        Assert.AreEqual(2, baseFuelReceipt.FlammableResourceRequired);
    }

    [Test]
    public void CryogenicResourceRequired_ShouldBe0()
    {
        Assert.AreEqual(0, baseFuelReceipt.CryogenicResourceRequired);
    }

    [Test]
    public void RadioactiveMaterialRequired_ShouldBe0()
    {
        Assert.AreEqual(0, baseFuelReceipt.RadioactiveMaterialRequired);
    }

    [Test]
    public void Name_ShouldBeAmmoReceiptName()
    {
        Assert.AreEqual("Ammo Receipt Name", baseFuelReceipt.Name);
    }
}
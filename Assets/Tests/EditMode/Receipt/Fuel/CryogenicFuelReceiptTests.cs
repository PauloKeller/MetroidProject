using NUnit.Framework;

[TestFixture]
public class CryogenicFuelReceiptTests
{
    private BaseFuelReceipt baseFuelReceipt;
    private CryogenicFuelReceipt cryogenicFuelReceipt;

    [SetUp]
    public void Setup()
    {
        baseFuelReceipt = new BaseFuelReceipt();
        cryogenicFuelReceipt = new CryogenicFuelReceipt(baseFuelReceipt);
    }

    [Test]
    public void FlammableResourceRequired_ShouldReturnBaseValuePlusOne()
    {
        Assert.AreEqual(baseFuelReceipt.FlammableResourceRequired + 1, cryogenicFuelReceipt.FlammableResourceRequired);
    }

    [Test]
    public void CryogenicResourceRequired_ShouldReturnBaseFlammableResourcePlusOne()
    {
        Assert.AreEqual(baseFuelReceipt.FlammableResourceRequired + 1, cryogenicFuelReceipt.CryogenicResourceRequired);
    }

    [Test]
    public void Name_ShouldReturnCryogenicFuel()
    {
        Assert.AreEqual("Cryogenic Fuel", cryogenicFuelReceipt.Name);
    }
}
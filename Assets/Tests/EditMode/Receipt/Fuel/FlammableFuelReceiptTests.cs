using NUnit.Framework;

[TestFixture]
public class FlammableFuelReceiptTests
{
    private BaseFuelReceipt baseFuelReceipt;
    private FlammableFuelReceipt flammableFuelReceipt;

    [SetUp]
    public void Setup()
    {
        baseFuelReceipt = new BaseFuelReceipt();
        flammableFuelReceipt = new FlammableFuelReceipt(baseFuelReceipt);
    }

    [Test]
    public void Name_ShouldReturnFlammableFuel()
    {
        Assert.AreEqual("Flammable Fuel", flammableFuelReceipt.Name);
    }
}
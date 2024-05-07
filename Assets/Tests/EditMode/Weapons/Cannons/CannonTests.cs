using NUnit.Framework;

class CannonTests
{
    [Test]
    public void CreateCannonTestPassed()
    {
        Cannon sut = new Cannon();

        Assert.AreEqual(sut.Weight, 25f);
        Assert.AreEqual(sut.FireRate, 15);
        Assert.AreEqual(sut.AmmoCapacity, 50);
    }
}
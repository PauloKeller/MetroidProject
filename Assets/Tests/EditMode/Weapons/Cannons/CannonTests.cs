using NUnit.Framework;

class CannonTests
{
    [Test]
    public void CreateCannonTestPasses()
    {
        Cannon sut = new Cannon();

        Assert.AreEqual(25f, sut.Weight);
        Assert.AreEqual(15, sut.FireRate);
        Assert.AreEqual(50, sut.AmmoCapacity);
        Assert.AreEqual(WeaponType.Cannon, sut.WeaponType);
    }
}
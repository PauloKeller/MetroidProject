using NUnit.Framework;

class FlamethrowerTests
{
    [Test]
    public void CreateFlamethrowerTestPasses()
    {
        Flamethrower sut = new Flamethrower();

        Assert.AreEqual(15f, sut.Weight);
        Assert.AreEqual(1, sut.FireRate);
        Assert.AreEqual(3000, sut.AmmoCapacity);
        Assert.AreEqual(WeaponType.Flamethrower, sut.WeaponType);
    }
}
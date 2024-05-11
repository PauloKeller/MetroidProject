using NUnit.Framework;

class FlamethrowerTests
{
    [Test]
    public void CreateFlamethrowerTestPasses()
    {
        Flamethrower sut = new Flamethrower();

        Assert.AreEqual(sut.Weight, 15f);
        Assert.AreEqual(sut.FireRate, 1);
        Assert.AreEqual(sut.AmmoCapacity, 3000);
        Assert.AreEqual(sut.WeaponType, WeaponType.Flamethrower);
    }
}
using NUnit.Framework;

class LaserTests 
{
    [Test]
    public void CreateLaserTestPasses()
    {
        Laser sut = new Laser();

        Assert.AreEqual(12.7f, sut.Weight);
        Assert.AreEqual(5 ,sut.FireRate);
        Assert.AreEqual(700, sut.AmmoCapacity);
        Assert.AreEqual(WeaponType.Laser, sut.WeaponType);
    }
}
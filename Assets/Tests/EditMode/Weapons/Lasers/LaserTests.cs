using NUnit.Framework;

class LaserTests 
{
    [Test]
    public void CreateLaserTestPasses()
    {
        Laser sut = new Laser();

        Assert.AreEqual(sut.Weight, 12.7f);
        Assert.AreEqual(sut.FireRate, 5);
        Assert.AreEqual(sut.AmmoCapacity, 700);
        Assert.AreEqual(sut.WeaponType, WeaponType.Laser);
    }
}
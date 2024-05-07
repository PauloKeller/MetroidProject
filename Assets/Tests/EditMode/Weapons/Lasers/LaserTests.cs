using NUnit.Framework;

class LaserTests 
{
    [Test]
    public void CreateLaserTestPassed()
    {
        Laser sut = new Laser();

        Assert.AreEqual(sut.Weight, 12.7f);
        Assert.AreEqual(sut.FireRate, 5);
        Assert.AreEqual(sut.AmmoCapacity, 700);
    }
}
using NUnit.Framework;

class MachineGunTests
{
    [Test]
    public void CreateMachineGunTestPassed()
    {
        MachineGun sut = new MachineGun();

        Assert.AreEqual(sut.Weight, 12f);
        Assert.AreEqual(sut.FireRate, 2);
        Assert.AreEqual(sut.AmmoCapacity, 2000);
    }
}
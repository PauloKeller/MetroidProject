using NUnit.Framework;

class MachineGunTests
{
    [Test]
    public void CreateMachineGunTestPasses()
    {
        MachineGun sut = new MachineGun();

        Assert.AreEqual(12f, sut.Weight);
        Assert.AreEqual(2, sut.FireRate);
        Assert.AreEqual(2000, sut.AmmoCapacity);
        Assert.AreEqual(WeaponType.MachineGun, sut.WeaponType);
        Assert.AreEqual(10, sut.CurrentProjectile.Damage);
    }

    [Test]
    public void SetMachineGunCurrentProjectilePasses()
    {
        MachineGun sut = new MachineGun();

        Assert.AreEqual(10, sut.CurrentProjectile.Damage);

        sut.CurrentProjectile = new FlammableBullet(new BaseBullet());

        Assert.AreEqual(20, sut.CurrentProjectile.Damage);
    }
}
using NUnit.Framework;

class MachineGunTests
{
    [Test]
    public void CreateMachineGunTestPasses()
    {
        MachineGun sut = new MachineGun();

        Assert.AreEqual(sut.Weight, 12f);
        Assert.AreEqual(sut.FireRate, 2);
        Assert.AreEqual(sut.AmmoCapacity, 2000);
        Assert.AreEqual(sut.WeaponType, WeaponType.MachineGun);
        Assert.AreEqual(sut.CurrentProjectile.Damage, 10);
    }

    [Test]
    public void SetMachineGunCurrentProjectilePasses()
    {
        MachineGun sut = new MachineGun();

        Assert.AreEqual(sut.CurrentProjectile.Damage, 10);

        sut.CurrentProjectile = new FlameBullet(new Bullet());

        Assert.AreEqual(sut.CurrentProjectile.Damage, 20);
    }
}
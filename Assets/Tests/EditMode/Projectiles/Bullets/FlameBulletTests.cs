using NUnit.Framework;

class FlameBulletTests
{
    [Test]
    public void CreateFlameBulletTestPasses()
    {
        FlameBullet sut = new FlameBullet(new Bullet());

        Assert.AreEqual(20, sut.Damage);
        Assert.AreEqual(12, sut.Speed);
        Assert.AreEqual(false, sut.IsPiercing);
        Assert.AreEqual(ProjectileType.Flammable, sut.ProjectileType);
    }
}
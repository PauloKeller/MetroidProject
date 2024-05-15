using NUnit.Framework;

class BulletTests
{
    [Test]
    public void CreateBulletTestPasses()
    {
        Bullet sut = new Bullet();

        Assert.AreEqual(10, sut.Damage);
        Assert.AreEqual(12f, sut.Speed);
        Assert.AreEqual(false, sut.IsPiercing);
        Assert.AreEqual(ProjectileType.Metal, sut.ProjectileType);
    }
}

using NUnit.Framework;

[TestFixture]
public class BaseBulletTests
{
    private BaseBullet bullet;

    [SetUp]
    public void SetUp()
    {
        bullet = new BaseBullet();
    }

    [Test]
    public void Damage_ShouldReturn10()
    {
        // Act
        int damage = bullet.Damage;

        // Assert
        Assert.AreEqual(10, damage);
    }

    [Test]
    public void Speed_ShouldReturn12f()
    {
        // Act
        float speed = bullet.Speed;

        // Assert
        Assert.AreEqual(12f, speed);
    }
}
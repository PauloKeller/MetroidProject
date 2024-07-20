using NUnit.Framework;

[TestFixture]
public class MetalBulletTests
{
    private MetalBullet metalBullet;
    private BaseBullet baseBullet;

    [SetUp]
    public void Setup()
    {
        baseBullet = new BaseBullet();
        metalBullet = new MetalBullet(baseBullet);
    }

    [Test]
    public void Damage_ReturnsExpectedValue()
    {
        // Act
        var damage = metalBullet.Damage;

        // Assert
        Assert.AreEqual(10, damage);
    }

    [Test]
    public void Speed_ReturnsExpectedValue()
    {
        // Act
        var speed = metalBullet.Speed;

        // Assert
        Assert.AreEqual(12f, speed);
    }

    [Test]
    public void Type_ReturnsExpectedValue()
    {
        // Act
        var type = metalBullet.Type;

        // Assert
        Assert.AreEqual(AmmoType.Bullet, type);
    }

    [Test]
    public void Name_ReturnsExpectedValue()
    {
        // Act
        var name = metalBullet.Name;

        // Assert
        Assert.AreEqual("Bullet", name);
    }
}
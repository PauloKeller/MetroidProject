using NUnit.Framework;

[TestFixture]
public class BulletAmmoStackTests
{
    [Test]
    public void Constructor_ShouldInitializeCorrectly()
    {
        // Arrange
        var baseBullet = new BaseBullet();
        var metalBullet = new MetalBullet(baseBullet);
        int amount = 100;

        // Act
        var ammoStack = new BulletAmmoStack(metalBullet, amount);

        // Assert
        Assert.AreEqual(metalBullet, ammoStack.bullet);
        Assert.AreEqual(amount, ammoStack.amount);
    }

    [Test]
    public void Amount_ShouldReturnCorrectValue()
    {
        // Arrange
        var baseBullet = new BaseBullet();
        var flameBullet = new FlameBullet(baseBullet);
        int amount = 50;
        var ammoStack = new BulletAmmoStack(flameBullet, amount);

        // Act
        int result = ammoStack.amount;

        // Assert
        Assert.AreEqual(50, result);
    }

    [Test]
    public void Bullet_ShouldReturnCorrectInstance()
    {
        // Arrange
        var baseBullet = new BaseBullet();
        var flameBullet = new FlameBullet(baseBullet);
        int amount = 50;
        var ammoStack = new BulletAmmoStack(flameBullet, amount);

        // Act
        var result = ammoStack.bullet;

        // Assert
        Assert.AreEqual(flameBullet, result);
    }

    [Test]
    public void FlameBullet_ShouldHaveIncreasedDamage()
    {
        // Arrange
        var baseBullet = new BaseBullet();
        var flameBullet = new FlameBullet(baseBullet);
        int amount = 50;
        var ammoStack = new BulletAmmoStack(flameBullet, amount);

        // Act
        int damage = ammoStack.bullet.Damage;

        // Assert
        Assert.AreEqual(20, damage); // Base damage 10 + 10 from FlameBullet
    }

    [Test]
    public void MetalBullet_ShouldHaveBaseDamage()
    {
        // Arrange
        var baseBullet = new BaseBullet();
        var metalBullet = new MetalBullet(baseBullet);
        int amount = 50;
        var ammoStack = new BulletAmmoStack(metalBullet, amount);

        // Act
        int damage = ammoStack.bullet.Damage;

        // Assert
        Assert.AreEqual(10, damage); // Base damage 10
    }
}
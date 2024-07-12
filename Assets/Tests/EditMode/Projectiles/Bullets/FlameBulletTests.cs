using NUnit.Framework;

public class FlameBulletTests
{
    [Test]
    public void Damage_ReturnsValidDamage()
    {
        // Arrange
        IBullet baseProjectile = new BaseBullet();
        FlameBullet flameBullet = new FlameBullet(baseProjectile);

        // Act
        int damage = flameBullet.Damage;

        // Assert
        Assert.AreEqual(20, damage); // 10 (base damage from Bullet) + 10 (additional damage from FlameBullet)
    }
}
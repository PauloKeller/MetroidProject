using NUnit.Framework;

public class FlameBulletTests
{
    [Test]
    public void Damage_ReturnsValidDamage()
    {
        // Arrange
        IProjectile baseProjectile = new Bullet();
        FlameBullet flameBullet = new FlameBullet(baseProjectile);

        // Act
        int damage = flameBullet.Damage;

        // Assert
        Assert.AreEqual(20, damage); // 10 (base damage from Bullet) + 10 (additional damage from FlameBullet)
    }

    [Test]
    public void ProjectileType_ReturnsValidType()
    {
        // Arrange
        IProjectile baseProjectile = new Bullet();
        FlameBullet flameBullet = new FlameBullet(baseProjectile);

        // Act
        ProjectileType type = flameBullet.ProjectileType;

        // Assert
        Assert.AreEqual(ProjectileType.Flammable, type);
    }
}
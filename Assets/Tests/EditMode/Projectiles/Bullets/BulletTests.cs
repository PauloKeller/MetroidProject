using NUnit.Framework;

public class BulletTests
{
    [Test]
    public void Damage_ReturnsValidDamage()
    {
        // Arrange
        Bullet bullet = new Bullet();

        // Act
        int damage = bullet.Damage;

        // Assert
        Assert.AreEqual(10, damage);
    }

    [Test]
    public void Speed_ReturnsValidSpeed()
    {
        // Arrange
        Bullet bullet = new Bullet();

        // Act
        float speed = bullet.Speed;

        // Assert
        Assert.AreEqual(12f, speed);
    }

    [Test]
    public void IsPiercing_ReturnsFalse()
    {
        // Arrange
        Bullet bullet = new Bullet();

        // Act
        bool isPiercing = bullet.IsPiercing;

        // Assert
        Assert.IsFalse(isPiercing);
    }

    [Test]
    public void ProjectileType_ReturnsValidType()
    {
        // Arrange
        Bullet bullet = new Bullet();

        // Act
        ProjectileType type = bullet.ProjectileType;

        // Assert
        Assert.AreEqual(ProjectileType.Metal, type);
    }
}

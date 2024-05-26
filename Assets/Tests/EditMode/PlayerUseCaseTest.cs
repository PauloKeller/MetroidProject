using NUnit.Framework;
using UnityEngine;

public class PlayerUseCaseTest
{
    private IPlayerUseCaseInterface sut;

    // A Test behaves as an ordinary method
    [SetUp]
    public void SetUp()
    {
        sut = new PlayerUseCase(moveSpeed: 5f);
    }

    [Test]
    public void CreatePlayerUseCaseTestPasses()
    {
        IPlayerUseCaseInterface sut = new PlayerUseCase(moveSpeed: 5f);

        Assert.AreEqual(Vector2.right, sut.FacingDir);
        Assert.AreEqual(WeaponType.MachineGun, sut.EquipedWeapon.WeaponType);
    }

    [Test]
    public void CalculateMovementTestPasses()
    {
        // Arrange
        Vector2 inputVector = new Vector2(1, 1);

        // Act
        sut.CalculateMovement(inputVector);

        // Assert
        Assert.AreEqual(inputVector.normalized, sut.FacingDir);
    }

    [Test]
    public void WieldWeaponTestPasses()
    {
        // Arrange
        WeaponType weaponType = WeaponType.MachineGun;

        // Act
        IWeapon weapon = sut.WieldWeapon(weaponType);

        // Assert
        Assert.AreEqual(weaponType, weapon.WeaponType);
        Assert.AreEqual(weapon, sut.EquipedWeapon);
    }

    [Test]
    public void ChangeCurrentWeaponAmmunitionTestPasses()
    {
        // Arrange
        sut.WieldWeapon(WeaponType.MachineGun);

        // Act
        IWeapon weapon = sut.ChangeCurrentWeaponAmmunition(ProjectileType.Flammable);

        // Assert
        Assert.IsTrue(weapon.CurrentProjectile is FlameBullet);
    }
}

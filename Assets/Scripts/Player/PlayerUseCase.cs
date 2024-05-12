using System;
using UnityEngine;

public interface IPlayerUseCaseInterface {
    Vector2 CalculateMovement(Vector2 inputVector);
    public Vector2 FacingDir { get; }
    public IWeapon WieldWeapon(WeaponType weaponType);
    public IWeapon EquipedWeapon { get; }
    public IWeapon ChangeCurrentWeaponAmmunition();
}
public class PlayerUseCase : IPlayerUseCaseInterface
{
    private IWeapon[] weapons = {
       new MiniGun(weapon: new MachineGun()),
       new PortableFlamethrower(weapon: new Flamethrower()),
       new LaserBeam(weapon: new Laser()),
       new HandCannon(weapon: new Cannon())
    };
    // TODO: Should be moved to the player model
    private float moveSpeed = 5f; 
    public Vector2 FacingDir { get;  private set; }
    public IWeapon EquipedWeapon { get; private set; }

    public PlayerUseCase(float moveSpeed) {
        this.moveSpeed = moveSpeed;
        this.FacingDir = Vector2.right;
        this.EquipedWeapon = new MiniGun(new MachineGun());
    }

    public Vector2 CalculateMovement(Vector2 inputVector)
    {
        if (inputVector.normalized != Vector2.zero) 
        {
            this.FacingDir = inputVector.normalized;
        }
        
        Vector2 xMovement = inputVector * moveSpeed;

        return new Vector2(xMovement.x, 0);
    }

    public IWeapon WieldWeapon(WeaponType weaponType) 
    {
        foreach (var item in weapons)
        {
            if (weaponType == item.WeaponType)
            {
                this.EquipedWeapon = item;
            }
        }

        return this.EquipedWeapon;
    }

    public IWeapon ChangeCurrentWeaponAmmunition() 
    {
        switch (this.EquipedWeapon.WeaponType)
        {
            case WeaponType.MachineGun:
                FlameBullet flameBullet = new FlameBullet(new Bullet());
                this.EquipedWeapon.CurrentProjectile = flameBullet;
                Debug.Log($"Changing {this.EquipedWeapon} bullet to {flameBullet}");
                break;
        }

        return this.EquipedWeapon;
    }
} 
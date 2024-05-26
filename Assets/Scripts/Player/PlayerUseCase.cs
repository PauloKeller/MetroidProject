using Codice.Client.BaseCommands.Merge;
using System;
using Unity.Services.Analytics;
using UnityEngine;

public interface IPlayerUseCaseInterface {
    Vector2 CalculateMovement(Vector2 inputVector);
    public Vector2 FacingDir { get; }
    public IWeapon WieldWeapon(WeaponType weaponType);
    public IWeapon EquipedWeapon { get; }
    public IWeapon ChangeCurrentWeaponAmmunition(ProjectileType projectileType);
}
public class PlayerUseCase : IPlayerUseCaseInterface
{
    // TODO: Should be moved to the inventory model
    private IWeapon[] weapons = {
       new MiniGun(weapon: new MachineGun()),
       new PortableFlamethrower(weapon: new Flamethrower()),
       new LaserBeam(weapon: new Laser()),
       new HandCannon(weapon: new Cannon())
    };

    private IProjectile[] machineGunProjectiles = {
        new Bullet(),
        new FlameBullet(new Bullet()),
    };

    private IProjectile[] flamethrowerProjectiles = {
        new FuelTank(),
        new NitrogenTank(new FuelTank()),
        new ChemicalTank(new FuelTank()),
    };

    private IProjectile[] laserProjectiles = {
        new EnergyCell(),
        new IceCell(new EnergyCell()),
        new NuclearCell(new EnergyCell()),
    };

    private IProjectile[] cannonProjectiles = {
        new NuclearShell(),
        new EMPShell(new NuclearShell()),
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
        
        Vector2 movement = inputVector * moveSpeed;

        return movement;
    }

    public IWeapon WieldWeapon(WeaponType weaponType) 
    {
        foreach (var item in weapons)
        {
            if (weaponType == item.WeaponType)
            {
                Debug.Log($"Equiped {item}");
                this.EquipedWeapon = item;
            }
        }

        return this.EquipedWeapon;
    }

    private IProjectile GetMachineGunAmmunition(ProjectileType projectileType) 
    {
        foreach (var item in machineGunProjectiles)
        {
            if (item.ProjectileType == projectileType) 
            {
                return item;
            }
        }

        return null;
    }

    private IProjectile GetFlamethrowerAmmunition(ProjectileType projectileType)
    {
        foreach (var item in flamethrowerProjectiles)
        {
            if (item.ProjectileType == projectileType)
            {
                return item;
            }
        }

        return null;
    }

    private IProjectile GetLaserAmmunition(ProjectileType projectileType)
    {
        foreach (var item in laserProjectiles)
        {
            if (item.ProjectileType == projectileType)
            {
                return item;
            }
        }

        return null;
    }

    private IProjectile GetCannonAmmunition(ProjectileType projectileType)
    {
        foreach (var item in cannonProjectiles)
        {
            if (item.ProjectileType == projectileType)
            {
                return item;
            }
        }

        return null;
    }

    public IWeapon ChangeCurrentWeaponAmmunition(ProjectileType projectileType) 
    {
        switch (this.EquipedWeapon.WeaponType)
        {
            case WeaponType.MachineGun:
                if (GetMachineGunAmmunition(projectileType: projectileType) is var mgAmmo && mgAmmo != null)
                {
                    Debug.Log($"Changed ammo {mgAmmo}");
                    this.EquipedWeapon.CurrentProjectile = mgAmmo;
                }
                break;
            case WeaponType.Flamethrower:
                if (GetFlamethrowerAmmunition(projectileType: projectileType) is var flameAmmo && flameAmmo != null)
                {
                    Debug.Log($"Changed ammo {flameAmmo}");
                    this.EquipedWeapon.CurrentProjectile = flameAmmo;
                }
                break;
            case WeaponType.Laser:
                if (GetLaserAmmunition(projectileType: projectileType) is var laserAmmo && laserAmmo != null)
                {
                    Debug.Log($"Changed ammo {laserAmmo}");
                    this.EquipedWeapon.CurrentProjectile = laserAmmo;
                }
                break;
            case WeaponType.Cannon:
                if (GetCannonAmmunition(projectileType: projectileType) is var cannonAmmo && cannonAmmo != null)
                {
                    Debug.Log($"Changed ammo {cannonAmmo}");
                    this.EquipedWeapon.CurrentProjectile = cannonAmmo;
                }
                break;
        }

        return this.EquipedWeapon;
    }
} 
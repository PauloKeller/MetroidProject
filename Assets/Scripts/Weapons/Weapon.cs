
public interface IWeapon 
{
    float Weight { get; }
    int FireRate { get; }
    int AmmoCapacity { get; }
    WeaponType WeaponType { get; }
    IProjectile CurrentProjectile { get; set; }
}

public abstract class Weapon : IWeapon
{
    protected IWeapon weapon;

    public Weapon(IWeapon weapon)
    {
        this.weapon = weapon;
    }

    public virtual float Weight 
    {
        get {
            return weapon.Weight;
        }
    }

    public virtual int FireRate 
    {
        get 
        {
            return weapon.FireRate;
        }

    }

    // TODO: Maybe should be moved to backpack or something like
    public virtual int AmmoCapacity 
    {
        get 
        {
            return weapon.AmmoCapacity;
        }
    }

    public virtual WeaponType WeaponType
    {
        get 
        {
            return weapon.WeaponType;
        }
    }

    public virtual IProjectile CurrentProjectile 
    {
        get 
        {
            return weapon.CurrentProjectile;
        }

        set 
        {
            weapon.CurrentProjectile = value;
        }
    }
}
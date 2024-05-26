public class Flamethrower : IWeapon
{
    private IProjectile currentAmmunition;

    public Flamethrower()
    {
        this.currentAmmunition = new FuelTank();
    }
    public float Weight 
    {
        get 
        {
            return 15f;
        }
    }

    public int FireRate 
    {
        get 
        {
            return 1;
        }
    }

    public int AmmoCapacity
    {
        get 
        {
            return 3000;
        }
    }

    public WeaponType WeaponType
    {
        get 
        {
            return WeaponType.Flamethrower;
        }
    }

    public IProjectile CurrentProjectile
    {
        get
        {
            return currentAmmunition;
        }
        set
        {
            this.currentAmmunition = value;
        }
    }

    public float MaxRange
    {
        get
        {
            return 4f;
        }
    }
}
public class Cannon : IWeapon
{
    private IProjectile currentAmmunition;

    public Cannon()
    {
        this.currentAmmunition = new NuclearShell();
    }

    public float Weight
    {
        get 
        {
            return 25f;
        }
    }

    public int FireRate
    {
        get
        {
            return 15;
        }
    }

    public int AmmoCapacity
    {
        get 
        {
            return 50;
        }
    }

    public WeaponType WeaponType
    {
        get
        {
            return WeaponType.Cannon;
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
            return 8f;
        }
    }
}

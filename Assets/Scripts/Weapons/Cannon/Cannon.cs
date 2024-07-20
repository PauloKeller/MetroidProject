public class Cannon : IWeapon
{
    private Missile currentAmmunition;

    public Cannon()
    {
        this.currentAmmunition = new NuclearMissile(new BaseMissile());
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

    public float MaxRange
    {
        get
        {
            return 8f;
        }
    }
}

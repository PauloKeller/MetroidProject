public class Laser : IWeapon
{
    private IProjectile currentAmmunition;

    public float Weight 
    {
        get 
        {
            return 12.7f;
        }
    }
    public int FireRate 
    {
        get 
        {
            return 5;
        }
    }
    public int AmmoCapacity 
    {
        get 
        {
            return 700;
        }
    }
    public WeaponType WeaponType
    {
        get 
        {
            return WeaponType.Laser;
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
}

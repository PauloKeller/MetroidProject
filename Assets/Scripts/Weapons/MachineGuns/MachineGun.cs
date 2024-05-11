public class MachineGun : IWeapon
{
    private IProjectile currentAmmunition;

    public MachineGun() 
    {
        this.currentAmmunition = new Bullet();
    }

    public float Weight
    {
        get
        {
            return 12f;
        }
    }

    public int FireRate
    {
        get
        {
            return 2;
        }
    }

    public int AmmoCapacity
    {
        get
        {
            return 2000;
        }
    }

    public WeaponType WeaponType
    {
        get
        {
            return WeaponType.MachineGun;
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
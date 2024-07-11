public class MachineGun : IWeapon
{
    private Bullet currentAmmunition;

    public MachineGun() 
    {
        this.currentAmmunition = new MetallicBullet(new BaseBullet());
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

    public Bullet CurrentProjectile
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
            return 15f;
        }
    }

    IProjectile IWeapon.CurrentProjectile { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
}
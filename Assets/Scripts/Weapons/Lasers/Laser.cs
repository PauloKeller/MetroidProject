public class Laser : IWeapon
{

    public Laser()
    {
    }

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
    public float MaxRange
    {
        get
        {
            return 17f;
        }
    }
}

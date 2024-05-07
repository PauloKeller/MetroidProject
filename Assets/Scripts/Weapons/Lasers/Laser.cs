public class Laser : IWeapon
{
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
}

public class Flamethrower : IWeapon
{
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
}
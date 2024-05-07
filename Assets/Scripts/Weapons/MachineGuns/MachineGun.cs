public class MachineGun : IWeapon
{
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
}
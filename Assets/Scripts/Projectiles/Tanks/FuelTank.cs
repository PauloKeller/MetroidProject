public class FuelTank : IProjectile
{
    public int Damage 
    {
        get 
        {
            return 5;
        }
    }

    public float Speed
    {
        get 
        {
            return 5;
        }
    }

    public bool IsPiercing
    {
        get 
        {
            return true;
        }
    }

    public ProjectileType ProjectileType
    {
        get 
        {
            return ProjectileType.Flammable;
        }
    }
}
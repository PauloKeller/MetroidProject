public class EnergyCell : IProjectile
{
    public int Damage 
    {
        get 
        {
            return 30;
        }
    }

    public float Speed 
    {
        get 
        {
            return 17f;
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
            return ProjectileType.Electrical;
        }
    }
}

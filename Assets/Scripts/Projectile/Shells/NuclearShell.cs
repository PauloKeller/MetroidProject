public class NuclearShell : IProjectile
{
    public int Damage
    {
        get 
        {
            return 100;
        }
    }

    public float Speed
    {
        get 
        {
            return 5f;
        }
    }

    public bool IsPiercing
    {
        get 
        {
            return false;
        }
    }

    public ProjectileType ProjectileType
    {
        get
        {
            return ProjectileType.Nuclear;
        }
    }
}
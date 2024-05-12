public class Bullet : IProjectile
{
    public int Damage
    {
        get 
        {
            return 10;
        }
    }

    public float Speed 
    {
        get 
        {
            return 12f;
        }
    }

    public bool IsPiercing 
    {
        get 
        {
            return false;
        }
    }
}
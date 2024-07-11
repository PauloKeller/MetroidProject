public class BaseBullet : IBullet
{
    public virtual int Damage
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
}
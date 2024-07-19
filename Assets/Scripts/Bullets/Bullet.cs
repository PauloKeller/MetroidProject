public abstract class Bullet: IBullet, IAmmo
{
    protected IBullet bullet;

    public Bullet(IBullet bullet)
    {
        this.bullet = bullet;
    }

    public virtual int Damage
    { 
        get { 
            return bullet.Damage; 
        }
    }

    public virtual float Speed
    {
        get { 
            return bullet.Speed; 
        }
    }

    public virtual string Name
    {
        get
        {
            return bullet.Name;
        }
    }

    public abstract AmmoType Type { get; }
}

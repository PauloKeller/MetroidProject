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

    public abstract string Name { get; }

    public abstract AmmoType Type { get; }
}

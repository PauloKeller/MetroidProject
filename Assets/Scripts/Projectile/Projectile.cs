public abstract class Projectile : IProjectile
{
    protected IProjectile projectile;

    public Projectile(IProjectile projectile)
    {
        this.projectile = projectile;
    }

    public virtual int Damage 
    {
        get 
        {
            return projectile.Damage;
        }
    }

    public virtual float Speed 
    {
        get
        {
            return projectile.Speed;
        }
    }

    public virtual bool IsPiercing 
    {
        get 
        {
            return projectile.IsPiercing;
        }
    }

    public virtual ProjectileType ProjectileType
    {
        get
        {
            return projectile.ProjectileType; 
        }
    }
}
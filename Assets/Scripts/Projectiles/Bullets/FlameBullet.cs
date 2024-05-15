public class FlameBullet : Projectile
{
    public FlameBullet(IProjectile projectile) : base(projectile)
    {
    }

    public override int Damage
    {
        get 
        {
            return base.Damage + 10;
        }
    }

    public override ProjectileType ProjectileType
    {
        get
        {
            return ProjectileType.Flammable;
        }
    }
}
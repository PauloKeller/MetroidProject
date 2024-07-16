public class CryogenicFlamethrowerAmmo: Projectile
{
    public CryogenicFlamethrowerAmmo(IProjectile projectile) : base(projectile)
    {
    }

    public override ProjectileType ProjectileType
    {
        get
        {
            return ProjectileType.Chemical;
        }
    }
}

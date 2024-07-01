public class EMPShell : Projectile
{
    public EMPShell(IProjectile projectile) : base(projectile)
    {
    }

    public override ProjectileType ProjectileType
    {
        get
        {
            return ProjectileType.Electrical;
        }
    }
}


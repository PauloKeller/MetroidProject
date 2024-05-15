public class IceCell : Projectile
{
    public IceCell(IProjectile projectile): base(projectile)
    { 
    }

    public override ProjectileType ProjectileType
    {
        get
        {
            return ProjectileType.Cryogenic;
        }
    }
}

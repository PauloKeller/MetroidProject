public class NitrogenTank : Projectile
{
    public NitrogenTank(IProjectile projectile) : base(projectile)
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
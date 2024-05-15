public class ChemicalTank: Projectile
{
    public ChemicalTank(IProjectile projectile) : base(projectile)
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

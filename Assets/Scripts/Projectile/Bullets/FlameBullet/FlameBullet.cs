public class FlameBullet : Projectile
{
    public FlameBullet(IProjectile projectile) : base(projectile)
    {
    }

    public override int Damage => base.Damage + 10;
}
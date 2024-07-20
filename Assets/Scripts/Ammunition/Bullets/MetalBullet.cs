public class MetalBullet : Bullet
{
    public MetalBullet(IBullet bullet) : base(bullet) { }

    public override string Name => "Bullet";
    public override AmmoType Type => AmmoType.Bullet;
}
public class FlameBullet : Bullet
{
    public FlameBullet(IBullet bullet) : base(bullet) { }

    public override int Damage => base.Damage + 10;
    public override string Name => "Flame Bullet";
    public override AmmoType Type => AmmoType.FlameBullet;
}
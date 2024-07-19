public class BaseBullet : IBullet, IAmmo
{
    public virtual int Damage => 10;
    public virtual float Speed => 12f;
    public virtual string Name => "Bullet Name";
    public virtual AmmoType Type => AmmoType.Unknown;
}
public class FlameBullet : Bullet
{
    public FlameBullet(IBullet bullet) : base(bullet)
    {
    }

    public override int Damage
    {
        get 
        {
            return base.Damage + 10;
        }
    }
}
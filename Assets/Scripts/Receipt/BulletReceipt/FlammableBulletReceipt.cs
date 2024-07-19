public class FlammableBulletReceipt : AmmoReceipt
{
    public FlammableBulletReceipt(IAmmoReceipt receipt) : base(receipt)
    {
    }

    public override int MetalResourceRequired
    {
        get
        {
            return base.MetalResourceRequired + 1;
        }
    }
    public override int FlammableResourceRequired
    {
        get
        {
            return base.FlammableResourceRequired + 2;
        }
    }

    public override string Name
    {
        get
        {
            return "Flame Bullet";
        }
    }
}

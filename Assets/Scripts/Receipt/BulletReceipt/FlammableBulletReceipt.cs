public class FlammableBulletReceipt : BulletReceipt 
{
    public FlammableBulletReceipt(IAmmoReceipt receipt) : base(receipt)
    {
    }

    public override int MetalMaterialRequired
    {
        get
        {
            return base.MetalMaterialRequired + 1;
        }
    }
    public override int FuelMaterialRequired
    {
        get
        {
            return base.FuelMaterialRequired + 2;
        }
    }
}

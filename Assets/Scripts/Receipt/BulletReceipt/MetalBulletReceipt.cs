public class MetalBulletReceipt : BulletReceipt
{
    public MetalBulletReceipt(IAmmoReceipt receipt) : base(receipt)
    {
    }

    public override string Name
    {
        get 
        {
            return "Bullet";
        }
    }
}
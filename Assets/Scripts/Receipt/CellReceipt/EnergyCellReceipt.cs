public class EnergyCellReceipt : BulletReceipt
{
    public EnergyCellReceipt(IAmmoReceipt receipt) : base(receipt)
    {
    }

    public override string Name
    {
        get
        {
            return "Energy Cell";
        }
    }
}

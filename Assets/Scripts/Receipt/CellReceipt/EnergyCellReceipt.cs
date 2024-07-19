public class EnergyCellReceipt : AmmoReceipt
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

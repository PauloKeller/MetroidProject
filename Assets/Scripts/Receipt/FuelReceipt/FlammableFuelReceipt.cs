public class FlammableFuelReceipt : AmmoReceipt
{
    public FlammableFuelReceipt(IAmmoReceipt receipt) : base(receipt)
    {
    }

    public override string Name
    {
        get
        {
            return "Flammable Fuel";
        }
    }
}
public class CryogenicFuelReceipt : FuelReceipt
{
    public CryogenicFuelReceipt(IAmmoReceipt receipt) : base(receipt)
    {
    }
    public override int FlammableResourceRequired
    {
        get
        {
            return base.FlammableResourceRequired + 1;
        }
    }

    public override int CryogenicResourceRequired
    {
        get
        {
            return base.FlammableResourceRequired + 1;
        }
    }

    public override string Name
    {
        get
        {
            return "Cryogenic Fuel";
        }
    }
}
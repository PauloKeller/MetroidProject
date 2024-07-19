public class ChemicalFuelReceipt : AmmoReceipt
{
    public ChemicalFuelReceipt(IAmmoReceipt receipt) : base(receipt)
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

    public override int ChemicalResourceRequired
    {
        get 
        { 
            return base.ChemicalResourceRequired + 2;
        }
    }
}

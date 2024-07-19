public class NuclearCellReceipt : AmmoReceipt
{
    public NuclearCellReceipt(IAmmoReceipt receipt) : base(receipt)
    {
    }

    public override string Name
    {
        get
        {
            return "Cryogenic Cell";
        }
    }

    public override int EnergyResourceRequired
    {
        get
        {
            return base.EnergyResourceRequired + 5;
        }
    }

    public override int ChemicalResourceRequired
    {
        get
        {
            return base.ChemicalResourceRequired + 1;
        }
    }

    public override int RadioactiveMaterialRequired
    {
        get
        {
            return base.RadioactiveMaterialRequired + 5;
        }
    }
}
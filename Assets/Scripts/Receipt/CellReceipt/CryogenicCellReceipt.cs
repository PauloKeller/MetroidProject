public class CryogenicCellReceipt : BulletReceipt
{
    public CryogenicCellReceipt(IAmmoReceipt receipt) : base(receipt)
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
            return base.EnergyResourceRequired + 1;
        }
    }

    public override int CryogenicResourceRequired
    {
        get
        {
            return base.CryogenicResourceRequired + 2;
        }
    }
}

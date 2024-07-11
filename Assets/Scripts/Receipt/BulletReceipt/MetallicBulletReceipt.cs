public class MetallicBulletReceipt : BulletReceipt
{
    public MetallicBulletReceipt(IAmmoReceipt receipt) : base(receipt)
    {
    }

    public override int MetalMaterialRequired
    {
        get 
        {
            return 1;
        }
    }

    public override int ChemicalMaterialRequired
    {
        get
        {
            return 0;
        }
    }
    public override int EnergyMaterialRequired
    {
        get
        {
            return 0;
        }
    }

    public override int FuelMaterialRequired
    {
        get
        {
            return 0;
        }
    }

    public override int RadioactiveMaterialRequired
    {
        get
        {
            return 0;
        }
    }
}
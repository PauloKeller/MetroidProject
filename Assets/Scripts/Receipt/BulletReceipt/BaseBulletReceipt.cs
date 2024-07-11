public class BaseBulletReceipt : IAmmoReceipt
{
    public int MetalMaterialRequired
    {
        get
        {
            return 1;
        }
    }

    public int ChemicalMaterialRequired
    {
        get
        {
            return 0;
        }
    }
    public int EnergyMaterialRequired
    {
        get
        {
            return 0;
        }
    }

    public int FuelMaterialRequired
    {
        get
        {
            return 0;
        }
    }

    public int RadioactiveMaterialRequired
    {
        get
        {
            return 0;
        }
    }
}

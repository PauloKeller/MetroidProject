public abstract class BulletReceipt : IAmmoReceipt
{
    protected IAmmoReceipt receipt;

    public BulletReceipt(IAmmoReceipt receipt)
    {
        this.receipt = receipt;
    }

    public virtual int MetalMaterialRequired
    {
        get 
        { 
            return receipt.MetalMaterialRequired;
        }
    }

    public virtual int ChemicalMaterialRequired
    {
        get
        {
            return receipt.ChemicalMaterialRequired;
        }
    }

    public virtual int EnergyMaterialRequired
    {
        get
        {
            return receipt.EnergyMaterialRequired;
        }
    }

    public virtual int FuelMaterialRequired
    {
        get
        {
            return receipt.FuelMaterialRequired;
        }
    }

    public virtual int RadioactiveMaterialRequired
    {
        get
        {
            return receipt.RadioactiveMaterialRequired;
        }
    }

    public virtual string Name
    {
        get
        {
            return receipt.Name;
        }
    }
}

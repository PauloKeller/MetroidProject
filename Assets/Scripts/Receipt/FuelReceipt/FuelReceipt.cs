public abstract class FuelReceipt : IAmmoReceipt
{
    protected IAmmoReceipt receipt;

    public FuelReceipt(IAmmoReceipt receipt)
    {
        this.receipt = receipt;
    }

    public virtual int MetalResourceRequired
    {
        get
        {
            return receipt.MetalResourceRequired;
        }
    }

    public virtual int ChemicalResourceRequired
    {
        get
        {
            return receipt.ChemicalResourceRequired;
        }
    }

    public virtual int EnergyResourceRequired
    {
        get
        {
            return receipt.EnergyResourceRequired;
        }
    }

    public virtual int FlammableResourceRequired
    {
        get
        {
            return receipt.FlammableResourceRequired;
        }
    }

    public virtual int CryogenicResourceRequired
    {
        get
        {
            return receipt.CryogenicResourceRequired;
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

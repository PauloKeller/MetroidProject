using System.Collections.Generic;

public abstract class MachineGunAmmoReceipt : IReceipt
{
    protected IReceipt receipt;

    public MachineGunAmmoReceipt(IReceipt receipt)
    {
        this.receipt = receipt;
    }

    public MachineGunAmmoReceipt()
    { 
    }
    public virtual int MetalMaterialAmount
    {
        get
        {
            return receipt.MetalMaterialAmount;
        }
    }

    public virtual int ChemicalMaterialAmount
    {
        get
        {
            return receipt.ChemicalMaterialAmount;
        }
    }

    public virtual int EnergyMaterialAmount
    {
        get
        {
            return receipt.EnergyMaterialAmount;
        }
    }

    public virtual int FuelMaterialAmount
    {
        get
        {
            return receipt.FuelMaterialAmount;
        }
    }

    public virtual int RadioactiveMaterialAmount
    {
        get
        {
            return receipt.RadioactiveMaterialAmount;
        }
    }
}
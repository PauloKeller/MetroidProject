using System.Collections.Generic;
using UnityEngine;

public struct RawMaterialStack 
{
    public int amount;
    public IRawMaterial rawMaterial;

    public RawMaterialStack(int amount, RawMaterialType rawMaterialType)
    {
        this.amount = amount;
        switch (rawMaterialType)
        {
            case RawMaterialType.Metal:
                this.rawMaterial = new MetalRawMaterial();
                break;
            case RawMaterialType.Chemical:
                this.rawMaterial = new ChemicalRawMaterial();
                break;
            case RawMaterialType.Fuel:
                this.rawMaterial = new FuelRawMaterial();
                break;
            case RawMaterialType.Energy:
                this.rawMaterial = new EnergyRawMaterial();
                break;
            case RawMaterialType.Radioactive:
                this.rawMaterial = new RadioactiveRawMaterial();
                break;
            default:
                this.rawMaterial = new MetalRawMaterial();
                break;
        }
    }
}

public class CraftUseCase
{
    private IRawMaterialRepository rawMaterialRepository = new RawMaterialRepository();
    private List<RawMaterialStack> storedRawMaterials = new List<RawMaterialStack>();
    public CraftUseCase() 
    {
        storedRawMaterials = rawMaterialRepository.FindAll();
    }

    public void CraftBullet(int amount, MachineGunAmmoReceipt receipt)
    {
        // TODO: Should be part of material receipt
        int metalRequired = receipt.MetalMaterialAmount * amount;
        int fuelRequired = receipt.FuelMaterialAmount * amount;
        int chemicalRequired = receipt.ChemicalMaterialAmount * amount;
        int energyRequired = receipt.EnergyMaterialAmount * amount;
        int radioactiveRequired = receipt.RadioactiveMaterialAmount * amount;

        List<RawMaterialStack> requiredRawMaterials = new List<RawMaterialStack>();

        if (HasEnoughMaterialsAmount(requiredRawMaterials: requiredRawMaterials,
            storedRawMaterials: storedRawMaterials))
        { 
           // TODO: Update the repository
        }
    }

    bool HasEnoughMaterialsAmount(List<RawMaterialStack> requiredRawMaterials, 
        List<RawMaterialStack> storedRawMaterials) 
    {
        foreach (RawMaterialStack storedMaterial in storedRawMaterials)
        {
            foreach (RawMaterialStack requiredRawMaterial in requiredRawMaterials)
            {
                if (storedMaterial.rawMaterial == requiredRawMaterial.rawMaterial)
                {
                    if (requiredRawMaterial.amount > storedMaterial.amount)
                    {
                        return false;
                    }
                }
            }
        }

        return true;
    }
}
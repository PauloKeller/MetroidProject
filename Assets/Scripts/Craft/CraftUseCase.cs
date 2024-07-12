using UnityEngine;
using System.Collections.Generic;
using System;

public class CraftUseCase
{
    private IRawMaterialRepository rawMaterialRepository = new RawMaterialRepository();
    private List<ResourceStack> resources = new List<ResourceStack>();
    public CraftUseCase()
    {
        resources = rawMaterialRepository.FindAll();
    }

    public List<ResourceStack> Resources {
        get
        { 
            return rawMaterialRepository.FindAll();
        }
    }

    public ResourceStack MetalStack 
    {
        get 
        {
            return resources.Find(resource => resource.resource is MetalResource);
        }
    }

    public ResourceStack FlammableStack
    {
        get
        {
            return resources.Find(resource => resource.resource is FlammableResource);
        }
    }

    public ResourceStack ChemicalbleStack
    {
        get
        {
            return resources.Find(resource => resource.resource is ChemicalResource);
        }
    }

    public ResourceStack EnergyStack
    {
        get
        {
            return resources.Find(resource => resource.resource is EnergyResource);
        }
    }

    public ResourceStack NuclearStack
    {
        get
        {
            return resources.Find(resource => resource.resource is NuclearResource);
        }
    }

    public BulletAmmoStack CraftBullet(int amount, BulletReceipt receipt)
    {
        resources = rawMaterialRepository.FindAll();

        if (HasEnoughMaterialsAmount(receipt: receipt, amount: amount))
        {
            if (receipt is MetalBulletReceipt)
            {
                Bullet bullet = new MetalBullet(new BaseBullet());
                BulletAmmoStack stack = new BulletAmmoStack(bullet: bullet, amount: amount);
                return stack;
            }
            else if (receipt is FlammableBulletReceipt)
            {
                FlameBullet bullet = new FlameBullet(new MetalBullet(new BaseBullet()));
                BulletAmmoStack stack = new BulletAmmoStack(bullet: bullet, amount: amount);
                return stack;
            }
            else 
            {
                throw new CraftMenuException(code: CraftMenuExceptionCode.NotAbleToCraftReceipt);
            }
        }
        else 
        {
            throw new CraftMenuException(code: CraftMenuExceptionCode.NotEnoughMaterials);
        }
    }

    private bool HasEnoughMaterialsAmount(IAmmoReceipt receipt, int amount) 
    {
        if (MetalStack.amount < (receipt.MetalMaterialRequired * amount))
        {
            return false;
        }
        else if (FlammableStack.amount < (receipt.FuelMaterialRequired * amount))
        {
            return false;
        }
        else if (ChemicalbleStack.amount < (receipt.ChemicalMaterialRequired * amount))
        {
            return false;
        }
        else if (EnergyStack.amount < (receipt.EnergyMaterialRequired * amount))
        {
            return false;
        }
        else if (NuclearStack.amount < (receipt.RadioactiveMaterialRequired * amount))
        {
            return false;
        }

        return true;
    }
}
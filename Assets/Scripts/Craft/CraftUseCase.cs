using System.Collections.Generic;

public class CraftUseCase
{
    private IResourceRepository rawMaterialRepository = new ResourceRepository();
    private AmmoRepository ammoRepository = new AmmoRepository();
    private List<ResourceStack> resourceStacks = new List<ResourceStack>();
    private List<AmmoStack> ammoStacks = new List<AmmoStack>();
    public CraftUseCase()
    {
        resourceStacks = rawMaterialRepository.FindAll();
        ammoStacks = ammoRepository.FindAll();
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
            return resourceStacks.Find(resource => resource.resource is MetalResource);
        }
    }

    public ResourceStack FlammableStack
    {
        get
        {
            return resourceStacks.Find(resource => resource.resource is FlammableResource);
        }
    }

    public ResourceStack CryogenicStack
    {
        get
        {
            return resourceStacks.Find(resource => resource.resource is CryogenicResource);
        }
    }

    public ResourceStack ChemicalbleStack
    {
        get
        {
            return resourceStacks.Find(resource => resource.resource is ChemicalResource);
        }
    }

    public ResourceStack EnergyStack
    {
        get
        {
            return resourceStacks.Find(resource => resource.resource is EnergyResource);
        }
    }

    public ResourceStack NuclearStack
    {
        get
        {
            return resourceStacks.Find(resource => resource.resource is NuclearResource);
        }
    }

    public BulletAmmoStack CraftAmmoReceipt(int amount, AmmoReceipt receipt)
    {
        resourceStacks = rawMaterialRepository.FindAll();

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
        if (MetalStack.quantity < (receipt.MetalResourceRequired * amount))
        {
            return false;
        }
        else if (FlammableStack.quantity < (receipt.FlammableResourceRequired * amount))
        {
            return false;
        }
        else if (ChemicalbleStack.quantity < (receipt.ChemicalResourceRequired * amount))
        {
            return false;
        }
        else if (EnergyStack.quantity < (receipt.EnergyResourceRequired * amount))
        {
            return false;
        }
        else if (NuclearStack.quantity < (receipt.RadioactiveMaterialRequired * amount))
        {
            return false;
        }

        return true;
    }
}
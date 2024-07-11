using System.Collections.Generic;

public class CraftUseCase
{
    private IRawMaterialRepository rawMaterialRepository = new RawMaterialRepository();
    private List<ResourceStack> storedRawMaterials = new List<ResourceStack>();
    public CraftUseCase()
    {
        storedRawMaterials = rawMaterialRepository.FindAll();
    }

    public BulletAmmoStack CraftBullet(int amount, BulletReceipt receipt)
    {
        if (HasEnoughMaterialsAmount(storedRawMaterials: storedRawMaterials, receipt: receipt))
        {
            if (receipt is MetallicBulletReceipt)
            {
                Bullet bullet = new MetallicBullet(new BaseBullet());
                BulletAmmoStack stack = new BulletAmmoStack(bullet: bullet, amount: amount);
                return stack;
            }
            else if (receipt is FlammableBulletReceipt)
            {
                FlameBullet bullet = new FlameBullet(new MetallicBullet(new BaseBullet()));
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

    private bool HasEnoughMaterialsAmount(List<ResourceStack> storedRawMaterials, IAmmoReceipt receipt) 
    {
        foreach (ResourceStack storedMaterial in storedRawMaterials)
        {
            if (storedMaterial.rawMaterial is MetalResource && storedMaterial.amount < receipt.MetalMaterialRequired)
            {
                return false;
            } 
            else if (storedMaterial.rawMaterial is FlammableResource && storedMaterial.amount < receipt.FuelMaterialRequired) 
            {
                return false;
            }
            else if (storedMaterial.rawMaterial is ChemicalResource && storedMaterial.amount < receipt.ChemicalMaterialRequired)
            {
                return false;
            }
            else if (storedMaterial.rawMaterial is EnergyResource && storedMaterial.amount < receipt.EnergyMaterialRequired)
            {
                return false;
            }
            else if (storedMaterial.rawMaterial is NuclearResource && storedMaterial.amount < receipt.RadioactiveMaterialRequired)
            {
                return false;
            }
        }

        return true;
    }
}
using System.Collections.Generic;

public class MetalBulletReceipt : AmmoReceipt
{
    public MetalBulletReceipt(IAmmoReceipt receipt) : base(receipt)
    {
    }

    public override IDictionary<ResourceType, int> ResourceRequirements
    {
        get
        {
            var baseRequirements = new Dictionary<ResourceType, int>(receipt.ResourceRequirements);
            baseRequirements[ResourceType.Metal] += 1;
            return baseRequirements;
        }
    }

    public override string Name
    {
        get 
        {
            return "Bullet";
        }
    }

    public override AmmoType AmmoType => AmmoType.Bullet;
}
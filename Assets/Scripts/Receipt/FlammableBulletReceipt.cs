using System.Collections.Generic;

public class FlammableBulletReceipt : AmmoReceipt
{
    public FlammableBulletReceipt(IAmmoReceipt receipt) : base(receipt)
    {
    }

    public override IDictionary<ResourceType, int> ResourceRequirements
    {
        get
        {
            var baseRequirements = new Dictionary<ResourceType, int>(receipt.ResourceRequirements);
            baseRequirements[ResourceType.Metal] += 1;
            baseRequirements[ResourceType.Flammable] += 2;
            return baseRequirements;
        }
    }

    public override string Name
    {
        get
        {
            return "Flame Bullet";
        }
    }

    public override AmmoType AmmoType => AmmoType.FlameBullet;
}

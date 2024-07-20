using System.Collections.Generic;

public class NuclearMissileReceipt : AmmoReceipt
{
    public NuclearMissileReceipt(IAmmoReceipt receipt) : base(receipt)
    {
    }

    public override string Name
    {
        get
        {
            return "Nuclear Missile";
        }
    }

    public override IDictionary<ResourceType, int> ResourceRequirements
    {
        get
        {
            var baseRequirements = new Dictionary<ResourceType, int>(receipt.ResourceRequirements);
            baseRequirements[ResourceType.Flammable] += 3;
            baseRequirements[ResourceType.Energy] += 5;
            baseRequirements[ResourceType.Metal] += 2;
            baseRequirements[ResourceType.Nuclear] += 7;
            return baseRequirements;
        }
    }

    public override AmmoType AmmoType => AmmoType.NuclearMissile;
}
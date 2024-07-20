using System.Collections.Generic;

public class EnergyMissileReceipt : AmmoReceipt
{
    public EnergyMissileReceipt(IAmmoReceipt receipt) : base(receipt)
    {
    }

    public override string Name
    {
        get
        {
            return "Energy Missile";
        }
    }

    public override IDictionary<ResourceType, int> ResourceRequirements
    {
        get
        {
            var baseRequirements = new Dictionary<ResourceType, int>(receipt.ResourceRequirements);
            baseRequirements[ResourceType.Energy] += 5;
            baseRequirements[ResourceType.Metal] += 2;
            baseRequirements[ResourceType.Nuclear] += 2;
            return baseRequirements;
        }
    }

    public override AmmoType AmmoType => AmmoType.EnergyMissile;
}
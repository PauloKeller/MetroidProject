using System.Collections.Generic;

public class FlammableFuelReceipt : AmmoReceipt
{
    public FlammableFuelReceipt(IAmmoReceipt receipt) : base(receipt)
    {
    }

    public override IDictionary<ResourceType, int> ResourceRequirements
    {
        get
        {
            var baseRequirements = new Dictionary<ResourceType, int>(receipt.ResourceRequirements);
            baseRequirements[ResourceType.Flammable] += 5;
            return baseRequirements;
        }
    }

    public override string Name
    {
        get
        {
            return "Flammable Fuel";
        }
    }

    public override AmmoType AmmoType => AmmoType.Fuel;
}
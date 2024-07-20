using System.Collections.Generic;

public class EnergyCellReceipt : AmmoReceipt
{
    public EnergyCellReceipt(IAmmoReceipt receipt) : base(receipt)
    {
    }

    public override IDictionary<ResourceType, int> ResourceRequirements
    {
        get
        {
            var baseRequirements = new Dictionary<ResourceType, int>(receipt.ResourceRequirements);
            baseRequirements[ResourceType.Energy] += 3;
            baseRequirements[ResourceType.Metal] += 2;
            return baseRequirements;
        }
    }

    public override string Name
    {
        get
        {
            return "Energy Cell";
        }
    }

    public override AmmoType AmmoType => AmmoType.EnergyCell;
}

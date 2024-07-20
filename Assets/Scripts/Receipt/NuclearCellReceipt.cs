using System.Collections.Generic;

public class NuclearCellReceipt : AmmoReceipt
{
    public NuclearCellReceipt(IAmmoReceipt receipt) : base(receipt)
    {
    }

    public override string Name
    {
        get
        {
            return "Nuclear Cell";
        }
    }

    public override IDictionary<ResourceType, int> ResourceRequirements
    {
        get
        {
            var baseRequirements = new Dictionary<ResourceType, int>(receipt.ResourceRequirements);
            baseRequirements[ResourceType.Energy] += 1;
            baseRequirements[ResourceType.Metal] += 1;
            baseRequirements[ResourceType.Nuclear] += 5;
            return baseRequirements;
        }
    }

    public override AmmoType AmmoType => AmmoType.NuclearCell;
}
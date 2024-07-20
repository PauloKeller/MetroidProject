using System.Collections.Generic;

public class CryogenicCellReceipt : AmmoReceipt
{
    public CryogenicCellReceipt(IAmmoReceipt receipt) : base(receipt)
    {
    }

    public override string Name
    {
        get
        {
            return "Cryogenic Cell";
        }
    }

    public override IDictionary<ResourceType, int> ResourceRequirements
    {
        get
        {
            var baseRequirements = new Dictionary<ResourceType, int>(receipt.ResourceRequirements);
            baseRequirements[ResourceType.Energy] += 2;
            baseRequirements[ResourceType.Metal] += 2;
            baseRequirements[ResourceType.Cryogenic] += 5;
            return baseRequirements;
        }
    }

    public override AmmoType AmmoType => AmmoType.CryogenicCell;
}

using System.Collections.Generic;

public class CryogenicFuelReceipt : AmmoReceipt
{
    public CryogenicFuelReceipt(IAmmoReceipt receipt) : base(receipt)
    {
    }
    public override IDictionary<ResourceType, int> ResourceRequirements
    {
        get
        {
            var baseRequirements = new Dictionary<ResourceType, int>(receipt.ResourceRequirements);
            baseRequirements[ResourceType.Flammable] += 1;
            baseRequirements[ResourceType.Cryogenic] += 2;
            return baseRequirements;
        }
    }

    public override string Name
    {
        get
        {
            return "Cryogenic Fuel";
        }
    }

    public override AmmoType AmmoType => AmmoType.CryogenicFuel;
}
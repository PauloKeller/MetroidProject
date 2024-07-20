using System.Collections.Generic;

public class ChemicalFuelReceipt : AmmoReceipt
{
    public ChemicalFuelReceipt(IAmmoReceipt receipt) : base(receipt)
    {
    }

    public override IDictionary<ResourceType, int> ResourceRequirements
    {
        get
        {
            var baseRequirements = new Dictionary<ResourceType, int>(receipt.ResourceRequirements);
            baseRequirements[ResourceType.Flammable] += 1;
            baseRequirements[ResourceType.Cryogenic] += 1;
            baseRequirements[ResourceType.Chemical] += 3;
            return baseRequirements;
        }
    }

    public override string Name
    {
        get
        {
            return "Chemical Fuel";
        }
    }

    public override AmmoType AmmoType => AmmoType.ChemicalFuel;
}

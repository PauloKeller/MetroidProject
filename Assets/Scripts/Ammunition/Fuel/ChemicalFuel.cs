public class ChemicalFuel : Fuel
{
    public ChemicalFuel(IFuel fuel) : base(fuel)
    {
    }

    public override AmmoType Type => AmmoType.ChemicalFuel;

    public override string Name => "Toxic Fuel";
}

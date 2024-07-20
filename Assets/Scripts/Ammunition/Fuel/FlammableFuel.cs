public class FlammableFuel : Fuel
{
    public FlammableFuel(IFuel fuel) : base(fuel) { }

    public override string Name => "Fuel";
    public override AmmoType Type => AmmoType.Fuel;
}
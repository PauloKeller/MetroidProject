public class CryogenicFuel : Fuel
{
    public CryogenicFuel(IFuel fuel) : base(fuel)
    {
    }

    public override AmmoType Type => AmmoType.CryogenicFuel;

    public override string Name => "Frozen Fuel";
}

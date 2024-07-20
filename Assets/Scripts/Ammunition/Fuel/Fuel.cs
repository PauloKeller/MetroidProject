public abstract class Fuel : IFuel, IAmmo
{
    protected IFuel fuel;

    public Fuel(IFuel fuel)
    {
        this.fuel = fuel;
    }

    public float DebuffDuration => fuel.DebuffDuration;
    public int DamageOverTimer => fuel.DamageOverTimer;
    public abstract AmmoType Type { get; }
    public abstract string Name { get; }
}

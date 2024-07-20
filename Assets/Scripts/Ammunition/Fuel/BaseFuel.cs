public class BaseFuel : IFuel, IAmmo
{
    public float DebuffDuration => 5.0f;
    public int DamageOverTimer => 5;
    public AmmoType Type => AmmoType.Fuel;
    public string Name => "Fuel name";
}

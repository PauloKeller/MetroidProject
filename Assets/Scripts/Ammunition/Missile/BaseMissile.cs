public class BaseMissile : IMissile, IAmmo
{
    public int Damage => 50;

    public float ExplosionRadius => 10f;

    public float ExplosionSpeed => 15f;

    public float ExecutionPercentage => 5f;

    public AmmoType Type => AmmoType.NuclearMissile;

    public string Name => "Missile Name";
}
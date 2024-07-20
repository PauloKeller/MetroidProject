public abstract class Missile : IMissile, IAmmo
{
    protected IMissile missile;

    public Missile(IMissile missile)
    {
        this.missile = missile;
    }

    public int Damage => missile.Damage;

    public float ExplosionRadius => missile.ExplosionRadius;

    public float ExplosionSpeed => missile.ExplosionSpeed;

    public float ExecutionPercentage => missile.ExecutionPercentage;

    public abstract AmmoType Type { get; }

    public abstract string Name { get; }
}
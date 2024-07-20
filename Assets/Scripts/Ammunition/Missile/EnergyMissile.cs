public class EnergyMissile : Missile
{
    public EnergyMissile(IMissile missile) : base(missile)
    {
    }

    public override AmmoType Type => AmmoType.EnergyMissile;
    public override string Name => "EPM Nuke";
}


public class NuclearMissile : Missile
{
    public NuclearMissile(IMissile missile) : base(missile)
    {
    }

    public override AmmoType Type => AmmoType.NuclearMissile;

    public override string Name => "Nuke";
}
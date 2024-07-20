public class BaseCell : ICell, IAmmo
{
    public int PiercingCount => 2;
    public int Damage => 10;
    public virtual string Name => "Cell Name";
    public virtual AmmoType Type => AmmoType.EnergyCell;
}

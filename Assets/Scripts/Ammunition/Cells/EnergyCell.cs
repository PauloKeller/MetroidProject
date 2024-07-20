public class EnergyCell : Cell
{
    public EnergyCell(ICell cell) : base(cell) { }

    public override AmmoType Type => AmmoType.EnergyCell;
    public override string Name => "Cell";
}

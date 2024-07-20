public class NuclearCell : Cell
{
    public NuclearCell(ICell cell) : base(cell) { }

    public override AmmoType Type => AmmoType.NuclearCell;
    public override string Name => "Atomic Cell";
}

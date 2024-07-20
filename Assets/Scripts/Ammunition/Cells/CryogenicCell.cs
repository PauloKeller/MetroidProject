public class CryogenicCell : Cell
{
    public CryogenicCell(ICell cell) : base(cell)
    {
    }

    public override AmmoType Type => AmmoType.CryogenicCell;

    public override string Name => "Frozen Cell";
}

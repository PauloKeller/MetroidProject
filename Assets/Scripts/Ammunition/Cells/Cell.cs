public abstract class Cell : ICell, IAmmo
{
    protected ICell cell;

    public Cell(ICell cell)
    {
        this.cell = cell;
    }

    public int PiercingCount => cell.PiercingCount;

    public int Damage => cell.Damage;

    public abstract AmmoType Type { get; }

    public abstract string Name { get; }
}

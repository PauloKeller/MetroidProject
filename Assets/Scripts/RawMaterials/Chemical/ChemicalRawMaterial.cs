public class ChemicalRawMaterial : IRawMaterial
{
    public float Weight
    {
        get
        {
            return 7f;
        }
    }

    public int MaxStack
    {
        get
        {
            return 9999;
        }
    }

    public string Description
    {
        get
        {
            return "";
        }
    }
}
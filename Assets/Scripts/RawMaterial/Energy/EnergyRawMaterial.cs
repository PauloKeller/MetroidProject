public class EnergyRawMaterial : IRawMaterial
{
    public float Weight
    {
        get
        {
            return 4f;
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

    public RawMaterialType Type
    {
        get
        {
            return RawMaterialType.Energy;
        }
    }
}
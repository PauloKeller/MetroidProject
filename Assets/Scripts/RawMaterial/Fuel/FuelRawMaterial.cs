public class FuelRawMaterial : IRawMaterial
{
    public float Weight
    {
        get 
        {
            return 1f;
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
            return RawMaterialType.Fuel;
        }
    }
}

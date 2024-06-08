public class Fuel : IRawMaterial
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
}

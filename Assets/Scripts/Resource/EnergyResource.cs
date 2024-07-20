public struct EnergyResource: IResource
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

    public ResourceType Type
    {
        get
        {
            return ResourceType.Energy;
        }
    }
}
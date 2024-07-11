public struct FlammableResource: IResource
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

    public ResourceType Type
    {
        get
        {
            return ResourceType.Fuel;
        }
    }
}

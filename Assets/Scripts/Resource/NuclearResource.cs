public struct NuclearResource: IResource
{
    public float Weight
    {
        get
        {
            return 10f;
        }
    }

    public int MaxStack
    {
        get
        {
            return 9999;
        }
    }

    // TODO: Should point to the translation table id
    public string Description
    {
        get
        {
            return "Iron ores are rocks and minerals from which metallic iron can be economically extracted.";
        }
    }

    public ResourceType Type
    {
        get
        {
            return ResourceType.Radioactive;
        }
    }
}
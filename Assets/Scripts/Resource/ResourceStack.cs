public struct ResourceStack
{
    public int quantity;
    public IResource resource;

    public ResourceStack(ResourceType type, int quantity)
    {
        this.quantity = quantity;
        this.resource = ResourceFactory.GetResource(type);
    }

    public ResourceStack(IResource resource, int quantity)
    {
        this.resource = resource;
        this.quantity = quantity;
    }
}

    
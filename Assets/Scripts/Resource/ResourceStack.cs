public struct ResourceStack
{
    public int amount;
    public IResource resource;

    public ResourceStack(ResourceType type, int amount)
    {
        this.amount = amount;
        switch (type)
        {
            case ResourceType.Metal:
                this.resource = new MetalResource();
                break;
            case ResourceType.Chemical:
                this.resource = new ChemicalResource();
                break;
            case ResourceType.Fuel:
                this.resource = new FlammableResource();
                break;
            case ResourceType.Energy:
                this.resource = new EnergyResource();
                break;
            case ResourceType.Radioactive:
                this.resource = new NuclearResource();
                break;
            default:
                this.resource = new MetalResource();
                break;
        }
    }

    public ResourceStack(IResource resource, int amount)
    {
        this.resource = resource;
        this.amount = amount;
    }
}

    
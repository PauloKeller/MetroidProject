public struct ResourceStack
{
    public int amount;
    public IResource rawMaterial;

    public ResourceStack(ResourceType type, int amount)
    {
        this.amount = amount;
        switch (type)
        {
            case ResourceType.Metal:
                this.rawMaterial = new MetalResource();
                break;
            case ResourceType.Chemical:
                this.rawMaterial = new ChemicalResource();
                break;
            case ResourceType.Fuel:
                this.rawMaterial = new FlammableResource();
                break;
            case ResourceType.Energy:
                this.rawMaterial = new EnergyResource();
                break;
            case ResourceType.Radioactive:
                this.rawMaterial = new NuclearResource();
                break;
            default:
                this.rawMaterial = new MetalResource();
                break;
        }
    }
}
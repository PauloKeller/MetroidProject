public abstract class RawMaterial: IRawMaterial
{
    protected IRawMaterial rawMaterial;

    public RawMaterial(IRawMaterial rawMaterial) 
    { 
        this.rawMaterial = rawMaterial;
    }
    public virtual float Weight
    {
        get 
        {
            return this.rawMaterial.Weight;
        }
    }

    public virtual int MaxStack 
    {
        get
        {
            return this.rawMaterial.MaxStack;
        }
    }

    public virtual string Description
    {
        get 
        {
            return this.rawMaterial.Description;
        }
    }

    public virtual RawMaterialType Type
    {
        get
        {
            return this.rawMaterial.Type;
        }
    }
}
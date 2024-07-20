using System.Collections.Generic;

public abstract class AmmoReceipt : IAmmoReceipt
{
    protected IAmmoReceipt receipt;

    public AmmoReceipt(IAmmoReceipt receipt)
    {
        this.receipt = receipt;
    }

    public virtual IDictionary<ResourceType, int> ResourceRequirements => receipt.ResourceRequirements;
    public virtual string Name => receipt.Name;
    public abstract AmmoType AmmoType { get; }
}
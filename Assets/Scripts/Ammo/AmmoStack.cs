public struct AmmoStack 
{
    public IAmmo ammo;
    public int quantity;

    public AmmoStack(IAmmo ammo, int quantity)
    { 
        this.ammo = ammo;
        this.quantity = quantity;
    }

    public AmmoStack(AmmoType type, int quantity)
    {
        this.quantity = quantity;
        this.ammo = AmmoFactory.GetAmmo(type);
    }
}
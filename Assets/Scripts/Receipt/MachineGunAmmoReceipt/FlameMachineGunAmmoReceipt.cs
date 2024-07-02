public class FlameMachineGunAmmoReceipt : MachineGunAmmoReceipt 
{
    public FlameMachineGunAmmoReceipt(IReceipt receipt) : base(receipt)
    {
    }

    public override int MetalMaterialAmount
    {
        get 
        { 
            return base.MetalMaterialAmount + 1; 
        }
    }

    public override int FuelMaterialAmount
    {
        get 
        {
            return base.FuelMaterialAmount + 1;
        }
    }
}

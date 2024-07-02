public class MetalMachineGunAmmoReceipt: MachineGunAmmoReceipt
{
    public override int MetalMaterialAmount
    {
        get { return 1; }
    }

    public override int ChemicalMaterialAmount
    {
        get { return 0; }
    }

    public override int EnergyMaterialAmount
    {
        get { return 0; }
    }

    public override int FuelMaterialAmount
    {
        get { return 0; }
    }
    public override int RadioactiveMaterialAmount
    {
        get { return 0; }
    }
}
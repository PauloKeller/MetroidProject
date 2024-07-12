public interface IAmmoReceipt
{
    string Name { get; }
    int MetalMaterialRequired { get; }
    int ChemicalMaterialRequired { get; }
    int EnergyMaterialRequired { get; }
    int FuelMaterialRequired { get; }
    int RadioactiveMaterialRequired { get; }
}
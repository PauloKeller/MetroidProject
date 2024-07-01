public interface IReceipt
{
    int MetalMaterialAmount { get; }
    int ChemicalMaterialAmount { get; }
    int EnergyMaterialAmount { get; }
    int FuelMaterialAmount { get; }
    int RadioactiveMaterialAmount { get; }
}

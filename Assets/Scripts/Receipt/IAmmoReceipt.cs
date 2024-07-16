public interface IAmmoReceipt
{
    string Name { get; }
    int MetalResourceRequired { get; }
    int FlammableResourceRequired { get; }
    int CryogenicResourceRequired { get; }
    int ChemicalResourceRequired { get; }
    int EnergyResourceRequired { get; }
    int RadioactiveMaterialRequired { get; }
}
using System.Collections.Generic;

public interface IAmmoReceipt
{
    string Name { get; }
    IDictionary<ResourceType, int> ResourceRequirements { get; }
    AmmoType AmmoType { get; }
}
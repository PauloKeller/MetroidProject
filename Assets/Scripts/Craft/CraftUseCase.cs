using System.Collections.Generic;
using System.Linq;

public interface ICraftUseCase 
{
    public void CraftAmmoReceipt(int amount, IAmmoReceipt receipt);
}

public class CraftUseCase: ICraftUseCase
{
    readonly IResourceRepository resourceRepository;
    readonly IAmmoRepository ammoRepository;
    IDictionary<AmmoType, AmmoStack> ammoDictionary;
    public IDictionary<ResourceType, ResourceStack> ResourceDictionary;
    public CraftUseCase(IResourceRepository resourceRepository, IAmmoRepository ammoRepository)
    {
        this.resourceRepository = resourceRepository;
        this.ammoRepository = ammoRepository;

        LoadResources();
    }

    private void LoadResources()
    {
        ResourceDictionary = resourceRepository.FindAll().ToDictionary(resource => (resource.resource).Type, resource => resource);
        ammoDictionary = ammoRepository.FindAll().ToDictionary(ammo => (ammo.ammo).Type, ammo => ammo);
    }

    public void CraftAmmoReceipt(int amount, IAmmoReceipt receipt)
    {
        if (!HasEnoughMaterials(receipt, amount))
        {
            throw new CraftMenuException(CraftMenuExceptionCode.NotEnoughMaterials);
        }

        DeductResources(receipt, amount);
        UpdateAmmo(receipt, amount);
        LoadResources();
    }

    private bool HasEnoughMaterials(IAmmoReceipt receipt, int amount)
    {
        return receipt.ResourceRequirements.All(requirement =>
            ResourceDictionary.TryGetValue(requirement.Key, out var stack) &&
            stack.quantity >= requirement.Value * amount);
    }

    private void DeductResources(IAmmoReceipt receipt, int amount)
    {
        foreach (var entry in receipt.ResourceRequirements)
        {
            var resourceType = entry.Key;
            var requiredAmount = entry.Value * amount;
            var stack = ResourceDictionary[resourceType];

            stack.quantity -= requiredAmount;
            resourceRepository.Update((int)resourceType, stack.quantity);
        }
    }

    private void UpdateAmmo(IAmmoReceipt receipt, int amount)
    {
        if (ammoDictionary.TryGetValue(receipt.AmmoType, out var ammoStack))
        {
            ammoStack.quantity += amount;
            ammoRepository.Update((int)receipt.AmmoType, ammoStack.quantity);
        }
        else
        {
            var newAmmoStack = new AmmoStack(receipt.AmmoType, amount);
            ammoDictionary[receipt.AmmoType] = newAmmoStack;
            ammoRepository.Update((int)receipt.AmmoType, newAmmoStack.quantity);
        }
    }
}
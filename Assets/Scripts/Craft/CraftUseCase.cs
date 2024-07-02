using UnityEngine;

public class CraftUseCase 
{
    public CraftUseCase() 
    {
        
    }

    // TODO: Need the repository to access the inventory store
    // simple implementation will mock the player repository
    public void CraftBullet(int amount, MachineGunAmmoReceipt receipt)
    {
        bool hasAllMaterials = true;

        if (hasAllMaterials)
        { 
           // TODO: Update the repository
        }
    }
}
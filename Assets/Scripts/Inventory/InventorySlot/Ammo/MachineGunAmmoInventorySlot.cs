public class MachineGunAmmoInventorySlot 
{
    public int Amount;
    // TODO: If necessary in the future create a structure to hold the ammo data
    public MachineGunAmmoReceipt AmmoReceipt;

    public MachineGunAmmoInventorySlot(int Amount, MachineGunAmmoReceipt AmmoReceipt)
    { 
        this.Amount = Amount;
        this.AmmoReceipt = AmmoReceipt;
    }
}
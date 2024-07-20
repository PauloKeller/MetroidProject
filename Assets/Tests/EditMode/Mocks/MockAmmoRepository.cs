using System.Collections.Generic;
using System.Linq;

public class MockAmmoRepository : IAmmoRepository
{
    private List<AmmoStack> ammo;

    public MockAmmoRepository(List<AmmoStack> initialAmmo)
    {
        ammo = initialAmmo;
    }

    public List<AmmoStack> FindAll()
    {
        return ammo;
    }

    public void Update(int id, int quantity)
    {
        var ammoStack = ammo.FirstOrDefault(a => (int)a.ammo.Type == id);
        if (ammoStack != null)
        {
            ammoStack.quantity = quantity;
        }
        else
        {
            ammo.Add(new AmmoStack((AmmoType)id, quantity));
        }
    }
}
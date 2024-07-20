using System;
using System.Collections.Generic;
public static class AmmoFactory 
{
    private static readonly Dictionary<AmmoType, IAmmo> ammoMap = new Dictionary<AmmoType, IAmmo>
    {
        { AmmoType.Bullet, new MetalBullet(new BaseBullet()) },
        { AmmoType.FlameBullet, new FlammableBullet (new MetalBullet(new BaseBullet())) },
        { AmmoType.Fuel, new FlammableFuel(new BaseFuel()) },
        { AmmoType.CryogenicFuel, new CryogenicFuel(new FlammableFuel(new BaseFuel())) },
        { AmmoType.ChemicalFuel, new ChemicalFuel(new CryogenicFuel(new FlammableFuel(new BaseFuel()))) },
        { AmmoType.EnergyCell, new EnergyCell(new BaseCell()) },
        { AmmoType.CryogenicCell, new CryogenicCell(new EnergyCell(new BaseCell())) },
        { AmmoType.NuclearCell, new NuclearCell(new CryogenicCell(new EnergyCell(new BaseCell()))) },
        { AmmoType.NuclearMissile, new NuclearMissile(new BaseMissile()) },
        { AmmoType.EnergyMissile, new EnergyMissile(new NuclearMissile(new BaseMissile())) },
    };

    public static IAmmo GetAmmo(AmmoType type)
    {
        if (ammoMap.TryGetValue(type, out var resource))
        {
            return resource;
        }
        throw new ArgumentException($"Unsupported ammo type: {type}");
    }
}

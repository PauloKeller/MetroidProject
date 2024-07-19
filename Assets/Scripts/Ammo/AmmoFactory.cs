using Codice.Client.BaseCommands.Merge;
using System;
using System.Collections.Generic;
using UnityEngine;

public static class AmmoFactory 
{
    private static readonly Dictionary<AmmoType, IAmmo> ammoMap = new Dictionary<AmmoType, IAmmo>
    {
        { AmmoType.Bullet, new MetalBullet(new BaseBullet()) },
        { AmmoType.FlameBullet, new MetalBullet (new BaseBullet()) }
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

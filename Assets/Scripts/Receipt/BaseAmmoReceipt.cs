using System.Collections.Generic;

public class BaseAmmoReceipt : IAmmoReceipt
{
    public IDictionary<ResourceType, int> ResourceRequirements => new Dictionary<ResourceType, int>
    {
        { ResourceType.Metal, 0 },
        { ResourceType.Flammable, 0 },
        { ResourceType.Cryogenic, 0 },
        { ResourceType.Chemical, 0 },
        { ResourceType.Energy, 0 },
        { ResourceType.Nuclear, 0 }
    };

    public string Name => "Receipt Name";
    public AmmoType AmmoType => AmmoType.Bullet;
}

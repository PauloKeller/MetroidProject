using System.Collections.Generic;
using System;

public static class ResourceFactory
{
    private static readonly Dictionary<ResourceType, IResource> resourceMap = new Dictionary<ResourceType, IResource>
    {
        { ResourceType.Metal, new MetalResource() },
        { ResourceType.Flammable, new FlammableResource() },
        { ResourceType.Cryogenic, new CryogenicResource() },
        { ResourceType.Chemical, new ChemicalResource() },
        { ResourceType.Energy, new EnergyResource() },
        { ResourceType.Nuclear, new NuclearResource() }
    };

    public static IResource GetResource(ResourceType type)
    {
        if (resourceMap.TryGetValue(type, out var resource))
        {
            return resource;
        }
        throw new ArgumentException($"Unsupported resource type: {type}");
    }
}
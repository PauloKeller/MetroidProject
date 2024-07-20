using System.Collections.Generic;
using System.Linq;

public class MockResourceRepository : IResourceRepository
{
    private List<ResourceStack> resources;

    public MockResourceRepository(List<ResourceStack> initialResources)
    {
        resources = initialResources;
    }

    public List<ResourceStack> FindAll()
    {
        return resources;
    }

    public void Update(int id, int quantity)
    {
        var resource = resources.FirstOrDefault(r => (int)r.resource.Type == id);
        if (resource != null)
        {
            resource.quantity = quantity;
        }
    }
}
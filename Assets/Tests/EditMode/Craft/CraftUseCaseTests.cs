using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;


[TestFixture]
public class CraftUseCaseTests
{
    private MockResourceRepository mockResourceRepository;
    private MockAmmoRepository mockAmmoRepository;
    private CraftUseCase craftUseCase;

    [SetUp]
    public void SetUp()
    {
        var resourceStacks = new List<ResourceStack>
        {
            new ResourceStack(new MetalResource(), 10),
            new ResourceStack(new FlammableResource(), 10),
            new ResourceStack(new CryogenicResource(), 10),
            new ResourceStack(new ChemicalResource(), 10),
            new ResourceStack(new EnergyResource(), 10),
            new ResourceStack(new NuclearResource(), 10)
            // Add more resource stacks as needed
        };

        var ammoStacks = new List<AmmoStack>
        {
            new AmmoStack(AmmoType.Bullet, 10),
            // Add more ammo stacks as needed
        };

        mockResourceRepository = new MockResourceRepository(resourceStacks);
        mockAmmoRepository = new MockAmmoRepository(ammoStacks);

        craftUseCase = new CraftUseCase(mockResourceRepository, mockAmmoRepository);
    }

    [Test]
    public void CraftAmmoReceipt_ShouldDeductResources_WhenResourcesAreSufficient()
    {
        // Arrange
        var baseReceipt = new BaseAmmoReceipt();

        var receipt = new ChemicalFuelReceipt(baseReceipt);

        // Act
        craftUseCase.CraftAmmoReceipt(1, receipt);

        // Assert
        var metalResource = mockResourceRepository.FindAll().First(r => r.resource.Type == ResourceType.Metal);
        var flammableResource = mockResourceRepository.FindAll().First(r => r.resource.Type == ResourceType.Flammable);
        var cryogenicResource = mockResourceRepository.FindAll().First(r => r.resource.Type == ResourceType.Cryogenic);
        var chemicalResource = mockResourceRepository.FindAll().First(r => r.resource.Type == ResourceType.Chemical);

        Assert.AreEqual(10, metalResource.quantity);
        Assert.AreEqual(9, flammableResource.quantity);
        Assert.AreEqual(9, cryogenicResource.quantity);
        Assert.AreEqual(7, chemicalResource.quantity);

        var chemicalFuelAmmo = mockAmmoRepository.FindAll().First(a => a.ammo.Type == AmmoType.ChemicalFuel);
        Assert.AreEqual(1, chemicalFuelAmmo.quantity);
    }

    [Test]
    public void CraftAmmoReceipt_ShouldThrowException_WhenResourcesAreInsufficient()
    {
        // Arrange
        var baseReceipt = new BaseAmmoReceipt();

        var receipt = new ChemicalFuelReceipt(baseReceipt);

        // Act & Assert
        Assert.Throws<CraftMenuException>(() => craftUseCase.CraftAmmoReceipt(100, receipt));
    }

    [Test]
    public void CraftAmmoReceipt_ShouldAddNewAmmo_WhenAmmoTypeDoesNotExist()
    {
        // Arrange
        var baseReceipt = new BaseAmmoReceipt();

        var receipt = new NuclearMissileReceipt(baseReceipt);

        // Act
        craftUseCase.CraftAmmoReceipt(1, receipt);

        // Assert
        var flammableResource = mockResourceRepository.FindAll().First(r => r.resource.Type == ResourceType.Flammable);
        var energyResource = mockResourceRepository.FindAll().First(r => r.resource.Type == ResourceType.Energy);
        var metalResource = mockResourceRepository.FindAll().First(r => r.resource.Type == ResourceType.Metal);
        var nuclearResource = mockResourceRepository.FindAll().First(r => r.resource.Type == ResourceType.Nuclear);

        Assert.AreEqual(7, flammableResource.quantity);
        Assert.AreEqual(5, energyResource.quantity);
        Assert.AreEqual(8, metalResource.quantity);
        Assert.AreEqual(3, nuclearResource.quantity);

        var nuclearMissileAmmo = mockAmmoRepository.FindAll().First(a => a.ammo.Type == AmmoType.NuclearMissile);
        Assert.AreEqual(1, nuclearMissileAmmo.quantity);
    }
}
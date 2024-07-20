using NUnit.Framework;

[TestFixture]
public class ResourceStackTests
{
    [Test]
    public void Constructor_WithResourceTypeAndAmount_ShouldInitializeCorrectly()
    {
        // Arrange
        int amount = 100;

        // Act
        var metalStack = new ResourceStack(ResourceType.Metal, amount);
        var cryogenicStack = new ResourceStack(ResourceType.Cryogenic, amount);
        var chemicalStack = new ResourceStack(ResourceType.Chemical, amount);
        var fuelStack = new ResourceStack(ResourceType.Flammable, amount);
        var energyStack = new ResourceStack(ResourceType.Energy, amount);
        var radioactiveStack = new ResourceStack(ResourceType.Nuclear, amount);

        // Assert
        Assert.AreEqual(amount, metalStack.quantity);
        Assert.IsInstanceOf<MetalResource>(metalStack.resource);

        Assert.AreEqual(amount, chemicalStack.quantity);
        Assert.IsInstanceOf<ChemicalResource>(chemicalStack.resource);

        Assert.AreEqual(amount, cryogenicStack.quantity);
        Assert.IsInstanceOf<CryogenicResource>(cryogenicStack.resource);

        Assert.AreEqual(amount, fuelStack.quantity);
        Assert.IsInstanceOf<FlammableResource>(fuelStack.resource);

        Assert.AreEqual(amount, energyStack.quantity);
        Assert.IsInstanceOf<EnergyResource>(energyStack.resource);

        Assert.AreEqual(amount, radioactiveStack.quantity);
        Assert.IsInstanceOf<NuclearResource>(radioactiveStack.resource);
    }

    [Test]
    public void Constructor_WithIResourceAndAmount_ShouldInitializeCorrectly()
    {
        // Arrange
        int amount = 50;
        IResource resource = new MetalResource();

        // Act
        var stack = new ResourceStack(resource, amount);

        // Assert
        Assert.AreEqual(amount, stack.quantity);
        Assert.AreEqual(resource, stack.resource);
    }
}
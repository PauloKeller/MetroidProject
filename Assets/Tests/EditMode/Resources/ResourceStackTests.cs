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
        var chemicalStack = new ResourceStack(ResourceType.Chemical, amount);
        var fuelStack = new ResourceStack(ResourceType.Fuel, amount);
        var energyStack = new ResourceStack(ResourceType.Energy, amount);
        var radioactiveStack = new ResourceStack(ResourceType.Radioactive, amount);

        // Assert
        Assert.AreEqual(amount, metalStack.amount);
        Assert.IsInstanceOf<MetalResource>(metalStack.resource);

        Assert.AreEqual(amount, chemicalStack.amount);
        Assert.IsInstanceOf<ChemicalResource>(chemicalStack.resource);

        Assert.AreEqual(amount, fuelStack.amount);
        Assert.IsInstanceOf<FlammableResource>(fuelStack.resource);

        Assert.AreEqual(amount, energyStack.amount);
        Assert.IsInstanceOf<EnergyResource>(energyStack.resource);

        Assert.AreEqual(amount, radioactiveStack.amount);
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
        Assert.AreEqual(amount, stack.amount);
        Assert.AreEqual(resource, stack.resource);
    }
}
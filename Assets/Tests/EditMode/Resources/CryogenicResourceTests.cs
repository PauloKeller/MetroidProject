using NUnit.Framework;

[TestFixture]
public class CryogenicResourceTests
{
    private CryogenicResource _cryogenicResource;

    [SetUp]
    public void Setup()
    {
        _cryogenicResource = new CryogenicResource();
    }

    [Test]
    public void Weight_ShouldBe7()
    {
        Assert.AreEqual(7f, _cryogenicResource.Weight);
    }

    [Test]
    public void MaxStack_ShouldBe9999()
    {
        Assert.AreEqual(9999, _cryogenicResource.MaxStack);
    }

    [Test]
    public void Description_ShouldBeEmpty()
    {
        Assert.AreEqual("", _cryogenicResource.Description);
    }

    [Test]
    public void Type_ShouldBeCryogenic()
    {
        Assert.AreEqual(ResourceType.Cryogenic, _cryogenicResource.Type);
    }
}
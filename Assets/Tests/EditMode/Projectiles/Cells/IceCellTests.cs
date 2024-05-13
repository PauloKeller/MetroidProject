using NUnit.Framework;

class IceCellTests 
{
    [Test]
    public void CreateIceCellTestPasses()
    {
        IceCell sut = new IceCell(new EnergyCell());

        Assert.AreEqual(30, sut.Damage);
        Assert.AreEqual(17f, sut.Speed);
        Assert.AreEqual(true, sut.IsPiercing);
        Assert.AreEqual(ProjectileType.Cryogenic, sut.ProjectileType);
    }
}
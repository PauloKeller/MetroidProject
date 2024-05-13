using NUnit.Framework;

class EnergyCellTests 
{
    [Test]
    public void CreateEnergyCellTestPasses()
    {
        EnergyCell sut = new EnergyCell();

        Assert.AreEqual(30, sut.Damage);
        Assert.AreEqual(17f, sut.Speed);
        Assert.AreEqual(true, sut.IsPiercing);
        Assert.AreEqual(ProjectileType.Electrical, sut.ProjectileType);
    }
}

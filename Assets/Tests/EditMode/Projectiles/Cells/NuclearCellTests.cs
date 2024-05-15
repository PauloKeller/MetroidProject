using NUnit.Framework;

class NuclearCellTests 
{
    [Test]
    public void CreateNuclearCellTestPasses()
    {
        NuclearCell sut = new NuclearCell(new EnergyCell());

        Assert.AreEqual(30, sut.Damage);
        Assert.AreEqual(17f, sut.Speed);
        Assert.AreEqual(true, sut.IsPiercing);
        Assert.AreEqual(ProjectileType.Nuclear, sut.ProjectileType);
    }
}

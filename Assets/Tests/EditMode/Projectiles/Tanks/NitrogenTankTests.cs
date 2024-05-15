using NUnit.Framework;

class NitrogenTankTests 
{
    [Test]
    public void CreateNitrogenTankTestPasses()
    {
        NitrogenTank sut = new NitrogenTank(new FuelTank());

        Assert.AreEqual(5, sut.Damage);
        Assert.AreEqual(ProjectileType.Cryogenic, sut.ProjectileType);
    }
}

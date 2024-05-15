
using NUnit.Framework;

class ChemicalTankTests 
{
    [Test]
    public void CreateChemicalTankTestPasses()
    {
        ChemicalTank sut = new ChemicalTank(new FuelTank());

        Assert.AreEqual(5, sut.Damage);
        Assert.AreEqual(ProjectileType.Chemical, sut.ProjectileType);
    }
}

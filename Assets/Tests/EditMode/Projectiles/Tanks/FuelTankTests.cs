using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FuelTankTests
{
    [Test]
    public void CreateFuelTankTestPasses()
    {
        FuelTank sut = new FuelTank();

        Assert.AreEqual(5, sut.Damage);
        Assert.AreEqual(5, sut.Speed);
        Assert.AreEqual(ProjectileType.Flammable, sut.ProjectileType);
    }
}

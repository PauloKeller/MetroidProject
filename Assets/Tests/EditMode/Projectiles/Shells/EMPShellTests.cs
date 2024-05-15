using NUnit.Framework;

class EMPShellTests
{
    [Test]
    public void CreateEMPShellTestPasses()
    {
        EMPShell sut = new EMPShell(new NuclearShell());

        Assert.AreEqual(100, sut.Damage);
        Assert.AreEqual(5f, sut.Speed);
        Assert.AreEqual(false, sut.IsPiercing);
        Assert.AreEqual(ProjectileType.Electrical, sut.ProjectileType);
    }
}

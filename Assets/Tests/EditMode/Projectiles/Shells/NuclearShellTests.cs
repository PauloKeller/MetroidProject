using NUnit.Framework;

class NuclearShellTests
{
    [Test]
    public void CreateNuclearShellTestPasses()
    {
        NuclearShell sut = new NuclearShell();

        Assert.AreEqual(100, sut.Damage);
        Assert.AreEqual(5f, sut.Speed);
        Assert.AreEqual(false, sut.IsPiercing);
        Assert.AreEqual(ProjectileType.Nuclear, sut.ProjectileType);
    }
}
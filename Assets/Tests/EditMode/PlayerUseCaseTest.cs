using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayerUseCaseTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void PlayerUseCaseTestSimplePasses()
    {
        IPlayerUseCaseInterface sut = new PlayerUseCase(moveSpeed: 5f);

        FlameBullet bullet = sut.CraftBullet() as FlameBullet;

        Assert.False(bullet.IsPiercing);
        Assert.GreaterOrEqual(bullet.Damage, 10);
    }
}

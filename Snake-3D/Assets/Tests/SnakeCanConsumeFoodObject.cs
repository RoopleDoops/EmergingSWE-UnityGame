using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using SnakeGame;
using UnityEngine;
using UnityEngine.TestTools;

public class SnakeCanConsumeFoodObject
{
    // A Test behaves as an ordinary method
    [Test]
    public void SnakeCanConsumeFoodObjectSimplePasses()
    {
        GameObject go = new GameObject();
        SnakeMovement player = go.AddComponent<SnakeMovement>();
        player.EatFoodForTest();

        Assert.IsTrue(player.FoodConsumedForTest());

        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator SnakeCanConsumeFoodObjectWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}

using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using SnakeGame;
public class SnakeGetsFasterAfterEating
{
    // A Test behaves as an ordinary method
    [Test]
    public void SnakeGetsFasterAfterEatingSimplePasses()
    {
        GameObject snakeSpeed = new GameObject();
        SnakeMovement increaseSnakeSpeed = snakeSpeed.AddComponent<SnakeMovement>();
        float actualSpeed = increaseSnakeSpeed.IncreaseSnakeSpeed();
        Assert.AreEqual(5.25, actualSpeed);

        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator SnakeGetsFasterAfterEatingWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}

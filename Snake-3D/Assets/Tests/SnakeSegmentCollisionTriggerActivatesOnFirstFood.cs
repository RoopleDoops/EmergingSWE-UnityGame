using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using SnakeGame;
using UnityEngine;
using UnityEngine.TestTools;

public class SnakeSegmentCollisionTriggerActivatesOnFirstFood
{
    // A Test behaves as an ordinary method
    [Test]
    public void SnakeSegmentCollisionTriggerActivatesOnFirstFoodSimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator SnakeSegmentCollisionTriggerActivatesOnFirstFoodWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}

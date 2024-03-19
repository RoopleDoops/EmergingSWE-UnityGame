using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using SnakeGame;
using UnityEngine;
using UnityEngine.TestTools;

public class SnakeGetsLongerAfterEating
{
    // A Test behaves as an ordinary method
    [Test]
    public void SnakeGetsLongerAfterEatingSimplePasses()
    {

        SnakeMovement test = new SnakeMovement(); // Create an instance of your imported script class
        
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator SnakeGetsLongerAfterEatingWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}

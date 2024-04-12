using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using SnakeGame;
using UnityEngine;
using UnityEngine.TestTools;

public class SetSpeedToZeroAfterDeath1
{
    // A Test behaves as an ordinary method
    [Test]
    public void SetSpeedToZeroAfterDeath1SimplePasses()
	{
		
			GameObject speed = new GameObject();
			SnakeMovement snake = speed.AddComponent<SnakeMovement>();
			snake.ResetSnake();
			float finalSpeed = snake.moveSpeedForTest;
			Assert.AreEqual(0f, finalSpeed);
		
	}

	// A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
	// `yield return null;` to skip a frame.
	[UnityTest]
    public IEnumerator SetSpeedToZeroAfterDeath1WithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}

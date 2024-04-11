using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using SnakeGame;
using UnityEngine;
using UnityEngine.TestTools;

public class SetYCameraMovementToZeroAfterDeath
{
    // A Test behaves as an ordinary method
    [Test]
    public void SetYCameraMovementToZeroAfterDeathSimplePasses()
    {
		{
			GameObject camera = new GameObject();
			SnakeMovement snake = camera.AddComponent<SnakeMovement>();
			snake.ResetSnake();
            float cameraY = snake.tiltAroundY;
			Assert.AreEqual(0f, cameraY);
		}
	}

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator SetYCameraMovementToZeroAfterDeathWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}

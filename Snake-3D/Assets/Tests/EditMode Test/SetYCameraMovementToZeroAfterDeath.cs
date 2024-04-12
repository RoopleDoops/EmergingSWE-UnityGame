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
		// Use the Assert class to test conditions

		GameObject camera = new GameObject();
		SnakeMovement snake = camera.AddComponent<SnakeMovement>();
		snake.ResetSnake();
		float cameraY = snake.tiltAroundY;
		Assert.AreEqual(0f, cameraY);
	}


}

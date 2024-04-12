using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using SnakeGame;
using UnityEngine;
using UnityEngine.TestTools;

public class SetSpeedToZeroAfterDeath
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


}

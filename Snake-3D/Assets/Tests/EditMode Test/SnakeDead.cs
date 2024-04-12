using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using SnakeGame;
using UnityEngine;
using UnityEngine.TestTools;

public class SnakeDead
{
    // A Test behaves as an ordinary method
    [Test]
    public void SnakeDeadSimplePasses()
    {

			// Use the Assert class to test conditions
			GameObject snake = new GameObject();
			SnakeMovement player = snake.AddComponent<SnakeMovement>();
			player.ResetSnake();
        bool playerStatus = player.isAlive;
		Assert.IsFalse(playerStatus);
	
	}

	// A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
	// `yield return null;` to skip a frame.
	[Test]
	public void SnakeAliveAtStatus()
	{

		// Use the Assert class to test conditions
		GameObject snake = new GameObject();
		SnakeMovement player = snake.AddComponent<SnakeMovement>();
		bool playerStatus = player.isAlive;
		Assert.IsTrue(playerStatus);


	}
}

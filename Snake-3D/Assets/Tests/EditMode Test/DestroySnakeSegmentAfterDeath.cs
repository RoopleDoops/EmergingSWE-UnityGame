using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using SnakeGame;
using UnityEngine;
using UnityEngine.TestTools;

public class DestroySnakeSegmentAfterDeath
{
    // A Test behaves as an ordinary method
    [Test]
    public void DestroySnakeSegmentAfterDeathSimplePasses()
	{
		// Use the Assert class to test conditions
		GameObject snake = new GameObject();
		SnakeMovement player = snake.AddComponent<SnakeMovement>();
		player.ResetSnake();
		float segmentCount = player.bodySegments.Count;
		Assert.AreEqual(0, segmentCount);
	}

}

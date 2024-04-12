using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using SnakeGame;

public class SnakeSegmentCollisionTriggerActivatesOnFirstFood
{
    // A Test behaves as an ordinary method
    [Test]
    public void SnakeSegmentCollisionTriggerActivatesOnFirstFoodSimplePasses()
    {
		GameObject food = new GameObject();
		food.tag = "Food";
		BoxCollider col = food.AddComponent<BoxCollider>();
		GameObject snake = new GameObject();
		SnakeMovement player = snake.AddComponent<SnakeMovement>();
		player.UpdateSegmentPosition();
		bool expected = player.snakeTrigger;

		Assert.IsTrue(expected);
	}

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.

}

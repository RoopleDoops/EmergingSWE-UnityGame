using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using SnakeGame;
public class GameEndsWhenSnakeCollidesWithObstacle
{
    // A Test behaves as an ordinary method
    [Test]
    public void GameEndsWhenSnakeCollidesWithObstacleSimplePasses()
    {
		// Use the Assert class to test conditions
		GameObject body = new GameObject();
		body.tag = "Obstacle";
		CapsuleCollider col = body.AddComponent<CapsuleCollider>();

		GameObject snake = new GameObject();
		SnakeMovement player = snake.AddComponent<SnakeMovement>();


		GameObject gameOver = new GameObject();
		GameOver gameStatus = gameOver.AddComponent<GameOver>();
		bool expected = gameStatus.GameOverScreen();
		Assert.IsTrue(expected);
	}


}

using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using SnakeGame;
public class GameEndsWhenSnakeCollidesWithWall
{
    // A Test behaves as an ordinary method
    [Test]
    public void GameEndsWhenSnakeCollidesWithWallSimplePasses()
    {
		// Use the Assert class to test conditions
		GameObject body = new GameObject();
		body.tag = "Out of Bounds";
		BoxCollider col = new BoxCollider();

		GameObject snake = new GameObject();
		SnakeMovement player = snake.AddComponent<SnakeMovement>();
		

		GameObject gameOver = new GameObject();
		GameOver gameStatus = gameOver.AddComponent<GameOver>();
		bool expected = gameStatus.GameOverScreen();
		Assert.IsTrue(expected);
	}


}

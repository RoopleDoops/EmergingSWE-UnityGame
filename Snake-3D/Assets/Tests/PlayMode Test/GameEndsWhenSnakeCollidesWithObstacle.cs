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
		//Assert
		GameObject pillars = new GameObject();
		pillars.tag = "Obstacle";
		CapsuleCollider col = pillars.AddComponent<CapsuleCollider>();

		GameObject snake = new GameObject();
		SnakeMovement player = snake.AddComponent<SnakeMovement>();

		GameObject gameOver = new GameObject();
		GameOver screen = gameOver.AddComponent<GameOver>();

		//Act 
		snake.transform.position = new Vector3(0, 0, 0);
		pillars.transform.position = new Vector3(0, 0, 0);

		bool gameOverScreen = screen.Setup();
		Assert.IsTrue(gameOverScreen);

	}

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator GameEndsWhenSnakeCollidesWithObstacleEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}

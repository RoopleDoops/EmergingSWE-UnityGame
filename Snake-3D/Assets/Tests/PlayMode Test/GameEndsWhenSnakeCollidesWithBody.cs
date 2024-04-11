using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using SnakeGame;
using UnityEngine;
using UnityEngine.TestTools;

public class GameEndsWhenSnakeCollidesWithBody
{
    // A Test behaves as an ordinary method
    [Test]
    public void GameEndsWhenSnakeCollidesWithBodySimplePasses()
    {
        //Assert
        GameObject body = new GameObject();
        body.tag = "Obstacle";
        BoxCollider col = body.AddComponent<BoxCollider>();

        GameObject snake = new GameObject();
        SnakeMovement player = snake.AddComponent<SnakeMovement>();

        GameObject gameOver = new GameObject();
        GameOver screen = gameOver.AddComponent<GameOver>();

        //Act
        snake.transform.position = new Vector3(0, 0, 0);
        body.transform.position = new Vector3(0, 0, 0);

        player.OnTriggerEnter(col);

        bool gameOverScreen = screen.Setup();
        Assert.IsTrue(gameOverScreen);
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator GameEndsWhenSnakeCollidesWithBodyEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}

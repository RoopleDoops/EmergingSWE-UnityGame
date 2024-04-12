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
        GameObject wall = new GameObject();
        wall.tag = "Obstacle";
        CapsuleCollider col = wall.AddComponent<CapsuleCollider>();

        GameObject snake = new GameObject();
        SnakeMovement player = snake.AddComponent<SnakeMovement>();

        GameObject gameOver = new GameObject();
        GameOver screen = gameOver.AddComponent<GameOver>();

       
        bool gameOverScreen = screen.GameOverScreen();
        Assert.IsTrue(gameOverScreen);




    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator GameEndsWhenSnakeCollidesWithWallEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}

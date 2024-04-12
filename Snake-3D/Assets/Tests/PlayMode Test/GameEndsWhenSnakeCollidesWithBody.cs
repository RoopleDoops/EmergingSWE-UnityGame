using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using SnakeGame;
public class GameEndsWhenSnakeCollidesWithBody
{
    // A Test behaves as an ordinary method
    [Test]
    public void GameEndsWhenSnakeCollidesWithBodySimplePasses()
    {
        GameObject body = new GameObject();
        body.tag = "Obstacle";
        BoxCollider col = body.AddComponent<BoxCollider>();
        GameObject snake = new GameObject();
        SnakeMovement player = snake.AddComponent<SnakeMovement>();
        

       GameObject gameOver = new GameObject();
        GameOver gameStatus = gameOver.AddComponent<GameOver>();
        bool expected = gameStatus.GameOverScreen();
        Assert.IsTrue(expected); 

    }

}

using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;
using SnakeGame;
public class ScoreIncreasesAfterEating
{
    // A Test behaves as an ordinary method
    [Test]
    public void ScoreIncreasesAfterEatingSimplePasses()
    {
        GameObject snake = new GameObject();
        ScoreManager eatFood = snake.AddComponent<ScoreManager>();
        GameObject points = new GameObject();
        ScoreManager pointsSystem = points.AddComponent<ScoreManager>();
        GameObject restartGame = new GameObject();
        GameOver restart = restartGame.AddComponent<GameOver>();
        int startingScore = pointsSystem.scoreCount;
        Debug.Log(startingScore);
        pointsSystem.AddPointsForTest();
        int updatedScore = pointsSystem.scoreCount;
        Debug.Log(updatedScore);
        pointsSystem.RestartForTest();
        Assert.True(updatedScore == 0);
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator ScoreIncreasesAfterEatingWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}

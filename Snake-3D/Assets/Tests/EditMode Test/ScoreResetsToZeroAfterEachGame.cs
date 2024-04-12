using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using SnakeGame;
public class ScoreResetsToZeroAfterEachGame
{
    // A Test behaves as an ordinary method
    [Test]
    public void ScoreResetsToZeroAfterEachGameSimplePasses()
    {
        GameObject snake = new GameObject();
        ScoreManager eatFood = snake.AddComponent<ScoreManager>();
        GameObject points = new GameObject();
        ScoreManager pointsSystem = points.AddComponent<ScoreManager>();
        int startingScore = pointsSystem.scoreCount;
        Debug.Log(startingScore);
        pointsSystem.AddPointsForTest();
        int updatedScore = pointsSystem.scoreCount;
        Debug.Log(updatedScore);
        int newScore = pointsSystem.scoreCount;
        Debug.Log(newScore);
        pointsSystem.RestartForTest();
        Assert.False(newScore == 0);
    }


}

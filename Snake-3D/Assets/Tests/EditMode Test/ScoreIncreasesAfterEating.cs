using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
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
        int startingScore = pointsSystem.scoreCount;
   
        pointsSystem.AddPointsForTest();
        int updatedScore = pointsSystem.scoreCount;
  
        Assert.False(updatedScore == 0);

    }


}

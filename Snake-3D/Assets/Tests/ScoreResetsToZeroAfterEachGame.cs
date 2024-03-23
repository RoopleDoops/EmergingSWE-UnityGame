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
        /*int scoreCount = 0;
        Assert.IsTrue(scoreCount == 0);*/

        GameObject snake = new GameObject();
        ScoreManager eatFood = snake.AddComponent<ScoreManager>();
        GameObject points = new GameObject();
        ScoreManager pointsSystem = points.AddComponent<ScoreManager>();
        int startingScore = pointsSystem.scoreCount;
        Debug.Log(startingScore);
        pointsSystem.AddPointsForTest();
        int updatedScore = pointsSystem.scoreCount;
        Debug.Log(updatedScore);
        Assert.False(updatedScore == 0);
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator ScoreResetsToZeroAfterEachGameWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}

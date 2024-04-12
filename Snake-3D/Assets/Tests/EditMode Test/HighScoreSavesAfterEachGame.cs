using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using SnakeGame;
public class HighScoreSavesAfterEachGame
{
    // A Test behaves as an ordinary method
    [Test]
    public void HighScoreSavesAfterEachGameSimplePasses()
    {
        int scoreCount = 200;
        int hiScoreCount = 150;

        if (hiScoreCount < scoreCount)
            hiScoreCount = scoreCount;

        scoreCount = 120; // New game = new score

        Assert.IsTrue(hiScoreCount > scoreCount);
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator HighScoreSavesAfterEachGameWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}

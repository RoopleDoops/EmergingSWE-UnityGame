using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using SnakeGame;
using UnityEngine;
using UnityEngine.TestTools;
using SnakeGame;

public class TitlePageWhenExitGame
{
    // A Test behaves as an ordinary method
    [Test]
    public void TitlePageWhenExitGameSimplePasses()
    {
		// Use the Assert class to test conditions
<<<<<<< Updated upstream:Snake-3D/Assets/Tests/DestroySnakeSegmentAfterDeath.cs
		GameObject snake = new GameObject();
		SnakeMovement player = snake.AddComponent<SnakeMovement>();
        player.ResetSnake();
        float segmentCount = player.bodySegments.Count; 
        Assert.AreEqual(0, segmentCount);
=======
		GameObject go = new GameObject();
		MainMenu player = go.AddComponent<MainMenu>();
		bool mainMenu = player.PlayGameForTest();
		Assert.IsTrue(mainMenu);
>>>>>>> Stashed changes:Snake-3D/Assets/Tests/PlayMode Test/TitlePageWhenExitGame.cs
	}

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator TitlePageWhenExitGameEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}

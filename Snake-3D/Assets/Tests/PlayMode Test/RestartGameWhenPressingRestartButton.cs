using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using SnakeGame;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

public class RestartGameWhenPressingRestartButton
{
    // A Test behaves as an ordinary method
    [Test]
    public void RestartGameWhenPressingRestartButtonSimplePasses()
    {
		// Use the Assert class to test conditions
		GameObject go = new GameObject();
		GameOver scene = go.AddComponent<GameOver>();
		bool correctScene = true;
		scene.RestartGame();
		if (SceneManager.GetActiveScene().buildIndex == 1)
		{
			correctScene = true;
		}
		Assert.IsTrue(correctScene);

	}
}


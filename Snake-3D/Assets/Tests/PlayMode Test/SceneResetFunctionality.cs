using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using SnakeGame;
using UnityEngine.SceneManagement;

public class SceneResetFunctionality
{
    // A Test behaves as an ordinary method
    [Test]
    public void SceneResetFunctionalitySimplePasses()
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

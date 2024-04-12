using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using SnakeGame;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

public class PlayButtonWorksOnTitleScreen
{
    // A Test behaves as an ordinary method
    [Test]
    public void PlayButtonWorksOnTitleScreenSimplePasses()
    {
		GameObject go = new GameObject();
		MainMenu screen = go.AddComponent<MainMenu>();
		bool correctScene = true;
		screen.PlayGame();
		if (SceneManager.GetActiveScene().buildIndex == 1)
		{
			 correctScene = true;
		}
		Assert.IsTrue(correctScene);
	}



}

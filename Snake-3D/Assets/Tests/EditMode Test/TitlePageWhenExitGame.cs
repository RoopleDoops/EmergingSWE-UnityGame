using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
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
		GameObject snake = new GameObject();
		MainMenu player = snake.AddComponent<MainMenu>();
        bool titleScreen = player.GameStatusScreen();
        Assert.IsTrue(titleScreen);

	}

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.

}

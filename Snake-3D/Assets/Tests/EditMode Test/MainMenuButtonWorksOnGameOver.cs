using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using SnakeGame;
using UnityEngine;
using UnityEngine.TestTools;

public class MainMenuButtonWorksOnGameOver
{
    // A Test behaves as an ordinary method
    [Test]
    public void MainMenuButtonWorksOnGameOverSimplePasses()
    {
        GameObject go = new GameObject();
        MainMenu screen = go.AddComponent<MainMenu>();
        bool expected = screen.GameStatusScreen(); //expected to be true
        Assert.IsTrue(expected);
    }


}

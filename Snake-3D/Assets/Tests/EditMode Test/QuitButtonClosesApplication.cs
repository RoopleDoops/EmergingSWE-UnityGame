using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using SnakeGame;
using UnityEngine;
using UnityEngine.TestTools;

public class QuitButtonClosesApplication
{
    // A Test behaves as an ordinary method
    [Test]
    public void QuitButtonClosesApplicationSimplePasses()
    {
        GameObject button = new GameObject(); 
        GameOver endGame = button.AddComponent<GameOver>();
        bool statusOfTheGame = endGame.GameOverScreen();
        Assert.IsTrue(statusOfTheGame); 
    }

}

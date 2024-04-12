using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using SnakeGame;
using UnityEngine;
using UnityEngine.TestTools;
using SnakeGame;

public class AudioScripts
{
    // A Test behaves as an ordinary method
    [Test]
    public void FoodSoundEffectPlays()
    {
        //Asserts
       

        GameObject snake = new GameObject();
        SnakeMovement player = snake.AddComponent<SnakeMovement>();
        player.PlayFoodCollectSound();
        bool soundFX = player.soundPlayed; 
        Assert.IsTrue(soundFX); 

    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator AudioScriptsWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}

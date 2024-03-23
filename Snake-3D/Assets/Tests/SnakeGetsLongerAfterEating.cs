using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using SnakeGame;
using UnityEngine;
using UnityEngine.TestTools;

public class SnakeGetsLongerAfterEating
{
    // A Test behaves as an ordinary method
    [Test]
    public void SnakeGetsLongerAfterEatingSimplePasses()
    {
        float startingSnakeLength = 5;
        GameObject snake = new GameObject();
        SnakeMovement snakeGrowth = snake.AddComponent<SnakeMovement>();
        snakeGrowth.EatFoodForTest();
        float finalSnakeLength = startingSnakeLength +  snakeGrowth.AddSegmenetsForTest(3);
        
        Assert.AreEqual(8f,finalSnakeLength);

    }

}

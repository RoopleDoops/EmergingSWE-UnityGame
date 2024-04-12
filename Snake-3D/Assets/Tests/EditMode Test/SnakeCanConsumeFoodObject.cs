using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using SnakeGame;
public class SnakeCanConsumeFoodObject
{
    // A Test behaves as an ordinary method
    [Test]
    public void SnakeCanConsumeFoodObjectSimplePasses()
    {
       
        GameObject go = new GameObject();
        SnakeMovement player = go.AddComponent<SnakeMovement>();
        player.EatFoodForTest();


        Assert.IsTrue(player.FoodConsumedForTest());


        // Use the Assert class to test conditions
    }

}

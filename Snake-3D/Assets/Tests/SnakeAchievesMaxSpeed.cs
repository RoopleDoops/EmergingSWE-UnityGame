using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using SnakeGame;
public class SnakeAchievesMaxSpeed
{
    // A Test behaves as an ordinary method
    [Test]
    public void SnakeAchievesMaxSpeedSimplePasses()
    {
       
        GameObject snakeSpeed = new GameObject();
        SnakeMovement maxSpeed = snakeSpeed.AddComponent<SnakeMovement>();
        float actualSpeed = maxSpeed.SnakeSpeed();
        Assert.AreEqual(10, actualSpeed);
        // Use the Assert class to test conditions
    }


}

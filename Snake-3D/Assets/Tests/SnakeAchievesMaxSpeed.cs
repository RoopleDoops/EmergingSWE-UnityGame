using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using SnakeGame;
using UnityEngine;
using UnityEngine.TestTools;

public class SnakeAchievesMaxSpeed
{
    // A Test behaves as an ordinary method
    [Test]
    public void SnakeAchievesMaxSpeedSimplePasses()
    {
        GameObject snakeSpeed = new GameObject();
        SnakeMovement maxSpeed = snakeSpeed.AddComponent<SnakeMovement>();
        float actualSpeed = maxSpeed.maxSnakeSpeed();

        Assert.AreEqual(10, actualSpeed);
        // Use the Assert class to test conditions
    }

    [Test]
    public void DoesNotExceedMaxSpeed()
    {
        GameObject snakeSpeed = new GameObject();
        SnakeMovement maxSpeed = snakeSpeed.AddComponent<SnakeMovement>();
        float maxSnakeSpeed = maxSpeed.maxSnakeSpeed();
        float startingSpeed = maxSnakeSpeed;
        float expectedFinalSpeed = startingSpeed;
        float increaseSpeed = maxSpeed.IncreaseSnakeSpeed();
        if (expectedFinalSpeed < maxSnakeSpeed)
        {
            expectedFinalSpeed += increaseSpeed;
        }

        Assert.AreEqual(maxSnakeSpeed, expectedFinalSpeed);
        // Use the Assert class to test conditions
    }
}

using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using SnakeGame;
using UnityEngine;
using UnityEngine.TestTools;

public class SnakeGetsFasterAfterEating
{
    // A Test behaves as an ordinary method
    [Test]
    public void SnakeGetsFasterAfterEatingSimplePasses()
    {
        GameObject snake = new GameObject();
        SnakeMovement snakeSpeed = snake.AddComponent<SnakeMovement>();
        float startingSnakeSpeed = 5;
        snakeSpeed.EatFoodForTest();
        float increaseSpeedAmount = snakeSpeed.moveSpeedForTest;
        float finalSnakeSpeed = startingSnakeSpeed + increaseSpeedAmount;
        Assert.AreEqual(5.25f, finalSnakeSpeed);

        // Use the Assert class to test conditions
    }

    [Test]
    public void SpeedIncreasesTowardsMaxSpeed()
    {
        GameObject snakeSpeed = new GameObject();
        SnakeMovement maxSpeed = snakeSpeed.AddComponent<SnakeMovement>();
        float maxSnakeSpeed = maxSpeed.maxSnakeSpeed();
        float startingSpeed = 5;
        float expectedFinalSpeed = startingSpeed;
        float increaseSpeed = maxSpeed.IncreaseSnakeSpeed();
        while (expectedFinalSpeed < maxSnakeSpeed)
        {
            expectedFinalSpeed += increaseSpeed;
        }

        Assert.AreEqual(maxSnakeSpeed, expectedFinalSpeed);
        // Use the Assert class to test conditions
    }
}

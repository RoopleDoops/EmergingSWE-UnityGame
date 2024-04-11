using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using SnakeGame;
using UnityEngine;
using UnityEngine.TestTools;

public class SetXCameraMovementToZero
{
    // A Test behaves as an ordinary method
    [Test]
    public void SetXCameraMovementToZeroSimplePasses()
    {
        GameObject camera = new GameObject();
        SnakeMovement snake = camera.AddComponent<SnakeMovement>();
        snake.ResetSnake();
        float cameraX = snake.tiltAroundX;
        Assert.AreEqual(0f, cameraX);
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator SetXCameraMovementToZeroWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}

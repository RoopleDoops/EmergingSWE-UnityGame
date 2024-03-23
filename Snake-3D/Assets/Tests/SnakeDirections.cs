using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using SnakeGame;
public class SnakeDirections
{
    // A Test behaves as an ordinary method
    [Test]
    public void Right()
    {
        GameObject direction = new GameObject();
        SnakeMovement snakeMovement = direction.AddComponent<SnakeMovement>();
        float verticalInputPositive = 1.0f;
        float horitzontolInput = 0f; 
        Vector3 expected =  snakeMovement.DirectionsForTest(verticalInputPositive, horitzontolInput);
        
        Assert.AreEqual(expected, snakeMovement.transform.position); 
        // Use the Assert class to test conditions
    }
    [Test]
    public void Left()
    {
        GameObject direction = new GameObject();
        SnakeMovement snakeMovement = direction.AddComponent<SnakeMovement>();
        float verticalInputPositive =-1.0f;
        float horitzontolInput = 0f;
        Vector3 expected = snakeMovement.DirectionsForTest(verticalInputPositive, horitzontolInput);

        Assert.AreEqual(expected, snakeMovement.transform.position);
        // Use the Assert class to test conditions
    }
    [Test]
    public void Up()
    {
        GameObject direction = new GameObject();
        SnakeMovement snakeMovement = direction.AddComponent<SnakeMovement>();
        float verticalInputPositive =0.0f;
        float horitzontolInput = 1.0f;
        Vector3 expected = snakeMovement.DirectionsForTest(verticalInputPositive, horitzontolInput);

        Assert.AreEqual(expected, snakeMovement.transform.position);
        // Use the Assert class to test conditions
    }
    [Test]
    public void Down()
    {
        GameObject direction = new GameObject();
        SnakeMovement snakeMovement = direction.AddComponent<SnakeMovement>();
        float verticalInputPositive = 0.0f;
        float horitzontolInput =-1.0f;
        Vector3 expected = snakeMovement.DirectionsForTest(verticalInputPositive, horitzontolInput);

        Assert.AreEqual(expected, snakeMovement.transform.position);
        // Use the Assert class to test conditions
    }


}

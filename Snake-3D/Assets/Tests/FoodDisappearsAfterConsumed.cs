using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using SnakeGame;
using UnityEngine;
using UnityEngine.TestTools;

public class FoodDisappearsAfterConsumed
{
    // A Test behaves as an ordinary method
    [Test]
    public void FoodDisappearsAfterConsumedSimplePasses()
    {
		//Food Object
		GameObject food = new GameObject();
		FoodObject foodPellet = food.AddComponent<FoodObject>();
		

		GameObject snake = new GameObject();
		snake.tag = "Player";
		SphereCollider col = snake.AddComponent<SphereCollider>();

		//Act
		snake.transform.position = new Vector3(0, 0, 0);
		food.transform.position = new Vector3(0, 0, 0);
/*
		foodPellet.OnTriggerEnter(col);*/

		Assert.IsNull(food);
		
	}

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator FoodDisappearsAfterConsumedWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}

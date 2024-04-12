using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using SnakeGame;
public class FoodDisappearsAfterConsumed
{
    // A Test behaves as an ordinary method
    [Test]
    public void FoodDisappearsAfterConsumedSimplePasses()
    {
		GameObject go = new GameObject();
		FoodObject food = go.AddComponent<FoodObject>();
		Vector3 original = food.RandomizePositionForTest();
		Vector3 final = food.RandomizePositionForTest();
		Assert.AreNotEqual(original, final);




	}


}

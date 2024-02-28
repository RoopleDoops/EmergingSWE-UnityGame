using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
<<<<<<< Updated upstream
=======

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            RandomizePositiion();
            
        }
    }

>>>>>>> Stashed changes
    void Update()
    {
        
    }

}
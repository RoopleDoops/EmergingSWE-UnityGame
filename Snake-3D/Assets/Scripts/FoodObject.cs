using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using FMODUnity;

public class FoodObject : MonoBehaviour
{
    [SerializeField] private EventReference foodCollectSound;
    public BoxCollider gridArea;


    void Start()


    {

        RandomizePositiion();

    }

    private void RandomizePositiion()

    {

        Bounds bounds = this.gridArea.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);

        float y = Random.Range(bounds.min.y, bounds.max.y);

        float z = Random.Range(bounds.min.z, bounds.max.z);

        this.transform.position = new Vector3(x, y, z);

    }

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)

    {

        if (other.tag == "Player")

        {
            AudioManager.instance.PlayOneShot(foodCollectSound, this.transform.position);
            RandomizePositiion();

        }

    }
}
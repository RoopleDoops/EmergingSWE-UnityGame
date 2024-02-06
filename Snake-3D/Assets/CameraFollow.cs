using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class CameraFollow : MonoBehaviour
{
    public GameObject playerSnake;
    private Transform snakeTransform;

    [SerializeField] private float followDistance = 4f;
    // Start is called before the first frame update
    void Start()
    {
        snakeTransform = playerSnake.GetComponent<Transform>();
        //snakeTransform = GameObject.Find("Test Snake").GetComponent<Transform>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Quaternion rotation = snakeTransform.rotation;
        transform.rotation = rotation;

        Vector3 playerVector = snakeTransform.position;
        // transform.position = new Vector3(playerVector.x, playerVector.y, playerVector.z - (followDistance * transform.forward.z));
        Vector3 direction = new Vector3(0, 0, -followDistance);
        transform.position = new Vector3(playerVector.x, playerVector.y, playerVector.z) + rotation * direction;

        //transform.LookAt(snakeTransform);
    }
}

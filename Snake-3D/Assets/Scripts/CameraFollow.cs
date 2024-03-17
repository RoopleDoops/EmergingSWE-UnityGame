using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
namespace SnakeGame {
public class CameraFollow : MonoBehaviour
{
    public GameObject playerSnakePrefab;
    private Transform snakeTransform;

    [SerializeField] private float zFollowDistance = -8f;
    [SerializeField] private float yFollowDistance = 2.5f;
    [SerializeField] private Vector3 cameraEulerAngle = new Vector3(15, 0, 0);
    private Quaternion cameraAngle;
    // Start is called before the first frame update
    void Start()
    {
        snakeTransform = playerSnakePrefab.GetComponent<Transform>();
        //snakeTransform = GameObject.Find("Test Snake").GetComponent<Transform>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Quaternion rotation = snakeTransform.rotation;
        cameraAngle.eulerAngles = cameraEulerAngle;
        transform.rotation = rotation * cameraAngle;

        Vector3 playerVector = snakeTransform.position;
        // transform.position = new Vector3(playerVector.x, playerVector.y, playerVector.z - (followDistance * transform.forward.z));
        Vector3 direction = new Vector3(0, yFollowDistance, zFollowDistance);
        transform.position = new Vector3(playerVector.x, playerVector.y, playerVector.z) + rotation * direction;

        //transform.LookAt(snakeTransform);
    }
}
}
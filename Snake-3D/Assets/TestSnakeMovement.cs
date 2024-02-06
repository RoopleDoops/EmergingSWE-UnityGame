using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    private float tiltSmooth = 3.0f; // Controls how fast direction change occurs
    [SerializeField] private float maxTiltAroundX = 30.0f; // maximum tilt
    [SerializeField] private float maxTiltAroundY = 10.0f; // maximum tilt
    [SerializeField] private float maxTiltAroundZ = 30.0f; // maximum tilt

    [SerializeField] private float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float tiltAroundX = -Input.GetAxis("Vertical") * maxTiltAroundX;
        float tiltAroundY = Input.GetAxis("Horizontal") * maxTiltAroundY;
        float tiltAroundZ = -Input.GetAxis("Horizontal") * maxTiltAroundZ;


        // Quat based on input angles
        Quaternion target = Quaternion.Euler(tiltAroundX, tiltAroundY, tiltAroundZ);


        // REVIEW later.
        //Vector3 eulerAng = transform.rotation.eulerAngles;

        // Target Quat set to current rotation * ("plus") target quat
        target = transform.rotation * target;

        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * tiltSmooth);


        // Move "forward" in space based on rotation
        transform.position += transform.forward * Time.deltaTime * moveSpeed;

        // DEBUG: Reset position to start
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = new Vector3(0, 0, 0);
            transform.rotation = new Quaternion(0, 0, 0, 0);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitMovement : MonoBehaviour
{
    public GameObject orbitObject;
    private Transform orbitObjectTransform;

    // Start is called before the first frame update
    void Start()
    {
        orbitObjectTransform = orbitObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        // Get difference in position
        Vector3 relativePosition = orbitObjectTransform.position - transform.position;
        // Get quaternion that looks in direction of relattive position (towards orbitObj)
        Quaternion rotation = Quaternion.LookRotation(relativePosition);
        // Store current rotation
        Quaternion current = transform.rotation;
        // Slerp between current and new rotation
        transform.rotation = rotation;// Quaternion.Slerp(current, rotation, Time.deltaTime);

        // Move "forward" along z-axis (towards object)
        transform.Translate(0, 0, 3 * Time.deltaTime);
    }
}

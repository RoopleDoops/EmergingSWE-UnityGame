using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    [SerializeField] private int startingSnakeLength = 3;
    [SerializeField] private float tiltSmooth = 5.0f; // Controls how fast direction change occurs
    [SerializeField] private float maxTiltAroundX = 30.0f; // maximum tilt
    [SerializeField] private float maxTiltAroundY = 30.0f; // maximum tilt
    [SerializeField] private float maxTiltAroundZ = 0.0f; // maximum tilt

    [SerializeField] private float moveSpeedDefault = 7f;
    [SerializeField] private float moveSpeedSprintAdd = 7f;
    private float moveSpeed;

    private float segmentUpdateTime;
    [SerializeField] private float segmentUpdateTimeMax = 0.25f;
    private Vector3 lastHeadPosition;
    private Quaternion lastHeadRotation;
    private Vector3 thisSegmentPosition;
    private Quaternion thisSegmentRotation;
    private Vector3 lastSegmentPosition;
    private Quaternion lastSegmentRotation;

    public GameObject snakeBodyPrefab;
    private List<GameObject> bodySegments = new List<GameObject>();

  
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = moveSpeedDefault;
        segmentUpdateTime = segmentUpdateTimeMax;
        lastHeadPosition = transform.position;
        lastHeadRotation = transform.rotation;
        thisSegmentPosition = transform.position;
        thisSegmentRotation = transform.rotation;
        lastSegmentPosition = transform.position;
        lastSegmentRotation = transform.rotation;
        // Initiate starting segments
        for (int i = 0; i < startingSnakeLength; i++)
        {
            AddSegment();
        }
    }

    // Update is called once per frame
    void Update()
    {
        float tiltAroundX = -Input.GetAxis("Vertical") * maxTiltAroundX;
        float tiltAroundY = Input.GetAxis("Horizontal") * maxTiltAroundY;
        float tiltAroundZ = -Input.GetAxis("Horizontal") * maxTiltAroundZ;


        // Quat based on input angles
        Quaternion target = Quaternion.Euler(tiltAroundX, tiltAroundY, tiltAroundZ);
        // Target Quat set to current rotation * ("plus") target quat
        target = transform.rotation * target;
        // Update head rotation based on target
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * tiltSmooth);


        // Sprint (increase speed while held)
        if (Input.GetKey(KeyCode.Mouse0))
        {
            moveSpeed = moveSpeedDefault + moveSpeedSprintAdd;
        }
        else
        {
            moveSpeed = moveSpeedDefault;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddSegment();
            AddSegment();
            AddSegment();
        }

        // Move "forward" in space based on rotation
        transform.position += transform.forward * Time.deltaTime * moveSpeed;

        // Update segment positions
        if (segmentUpdateTime > 0f) segmentUpdateTime -= Time.deltaTime;
        else UpdateSegmentPosition();

        // DEBUG: Reset position
        if (Input.GetKey(KeyCode.Escape))
        {
            transform.position = new Vector3(0, 5, -20);
            transform.rotation = new Quaternion(0, 0, 0, 0);
        }

    }

    // Updates position of all segments of snake
    private void UpdateSegmentPosition()
    {
        segmentUpdateTime += segmentUpdateTimeMax;
        for (int i = 0; i < bodySegments.Count; i++)
        {
            GameObject segment = bodySegments[i];

            // Store current position to pass to next segment.
            thisSegmentPosition = segment.transform.position;
            thisSegmentRotation = segment.transform.rotation;

            if (segment == bodySegments[0])
            {
                segment.transform.position = lastHeadPosition;
                segment.transform.rotation = lastHeadRotation;
            }
            else
            {
                segment.transform.position = lastSegmentPosition;
                segment.transform.rotation = lastSegmentRotation;
            }

            // Pass this segment's position before update to use for next segment.
            lastSegmentPosition = thisSegmentPosition;
            lastSegmentRotation = thisSegmentRotation;

        }
        // store current head position
        lastHeadPosition = transform.position;
        lastHeadRotation = transform.rotation;
    }

    // Adds a new segment to the back of the snake
    private void AddSegment()
    {
        Vector3 spawnPosition;
        if (bodySegments.Count == 0)
        {
            spawnPosition = transform.position;
        }
        else
        {
            spawnPosition = bodySegments[bodySegments.Count - 1].transform.position;
        }

        GameObject lastSegment = Instantiate(snakeBodyPrefab, spawnPosition, Quaternion.identity);

        bodySegments.Add(lastSegment);

    }
}

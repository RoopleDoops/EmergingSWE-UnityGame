using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SphereMovement : MonoBehaviour
{
    [SerializeField] private int startingSnakeLength = 5;
    [SerializeField] private float tiltSmooth = 5.0f; // Controls how fast direction change occurs
    [SerializeField] private float maxTiltAroundX = 30.0f; // maximum tilt x
    [SerializeField] private float maxTiltAroundY = 30.0f; // maximum tilt y

    [SerializeField] private float moveSpeedDefault = 7f;
    private float moveSpeed;
    [SerializeField] private float increaseSpeedAmount = 0.25f;

    private float segmentUpdateTime;
    [SerializeField] private float segmentUpdateTimeMax = 0.25f;
    // Variables for controlling position/rotation of head and segments
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
            SpawnDelay();
            AddSegment();
        } 
    }

    // Update is called once per frame
    void Update()
    {
        // Get axis-tilt from input
        float tiltAroundX = -Input.GetAxis("Vertical") * maxTiltAroundX;
        float tiltAroundY = Input.GetAxis("Horizontal") * maxTiltAroundY;

        // Apply rotation to head
        Quaternion target = Quaternion.Euler(tiltAroundX, tiltAroundY, 0);
        target = transform.rotation * target;
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * tiltSmooth); // smoothes transition

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

        // DEBUG
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnDelay();
            AddSegment();
            AddSegment();
            AddSegment();
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
        Quaternion spawnRotation;
        if (bodySegments.Count == 0)
        {
            

            spawnPosition = transform.position;
            spawnRotation = transform.rotation;
        }
        else
        {
            
            GameObject segment = bodySegments[bodySegments.Count - 1];
            spawnPosition = segment.transform.position;
            spawnRotation = segment.transform.rotation;
        }

        GameObject lastSegment = Instantiate(snakeBodyPrefab, spawnPosition, spawnRotation);

        bodySegments.Add(lastSegment);

    }
<<<<<<< Updated upstream
=======
    private IEnumerable SpawnDelay()
    {
        yield return new WaitForSeconds(3);
    }

    //increase speed when food is consumed
    private void IncreaseSpeed()
    {
        if(moveSpeed == 14)
        {
            moveSpeed = 14; // max speed 
        }
        else
        {
            moveSpeed += increaseSpeedAmount;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Food")
        {
            AddSegment();
            IncreaseSpeed();
        }
        else if (other.tag == "Obstacle")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Out of Bounds")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
>>>>>>> Stashed changes
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

namespace SnakeGame {
public class SnakeMovement : MonoBehaviour
{
    [SerializeField] private int startingSnakeLength = 5;
    [SerializeField] private float inputSensitivity = 5.0f; // Controls how fast direction change occurs
    [SerializeField] private float maxTiltAroundX = 30.0f; // maximum tilt x
    [SerializeField] private float maxTiltAroundY = 30.0f; // maximum tilt y

    [SerializeField] private float moveSpeedDefault = 5f;
    private float moveSpeed;
        public float moveSpeedForTest; //for testing purposes
    [SerializeField] private float increaseSpeedAmount = 0.25f;
    [SerializeField] private float maxSpeed = 10f;

    private float segmentUpdateTimeMax; // controls how often segments "move"
    private float segmentUpdateTime; // tracks time until next segment move happens
    
    // Variables for controlling position/rotation of head and segments
    private Vector3 lastHeadPosition;
    private Quaternion lastHeadRotation;
    private Vector3 thisSegmentPosition;
    private Quaternion thisSegmentRotation;
    private Vector3 lastSegmentPosition;
    private Quaternion lastSegmentRotation;

    public GameObject snakeBodyPrefab;
    private List<GameObject> bodySegments = new List<GameObject>();
    public  bool foodConsumed= false;
    public GameOver GameOver;


        // Start is called before the first frame update
        void Start()
    {
        moveSpeed = moveSpeedDefault;
        segmentUpdateTimeMax = 1 / moveSpeed;
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
        // Get axis-tilt from input
        float tiltAroundX = -Input.GetAxis("Vertical") * maxTiltAroundX;
        float tiltAroundY = Input.GetAxis("Horizontal") * maxTiltAroundY;

        // Apply rotation to head
        Quaternion target = Quaternion.Euler(tiltAroundX, tiltAroundY, 0);
        target = transform.rotation * target;
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * inputSensitivity); // smoothes transition

        // Move "forward" in space based on rotation
        transform.position += transform.forward * Time.deltaTime * moveSpeed;

        // Update segment positions
        if (segmentUpdateTime > 0f) segmentUpdateTime -= Time.deltaTime;
        else UpdateSegmentPosition();

    }
        public Vector3 DirectionsForTest(float xInput, float yInput)
        {
            float tiltAroundX = -Input.GetAxis("Vertical") * maxTiltAroundX;
            float tiltAroundY = Input.GetAxis("Horizontal") * maxTiltAroundY;
            // Apply rotation to head
            Quaternion target = Quaternion.Euler(tiltAroundX, tiltAroundY, 0);
            target = transform.rotation * target;
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * inputSensitivity); // smoothes transition

            // Move "forward" in space based on rotation
            Vector3 placement = transform.position += transform.forward * Time.deltaTime * moveSpeed;
            return placement;

        }

        // Updates position of all segments of snake
        private void UpdateSegmentPosition()
    {

        segmentUpdateTime += segmentUpdateTimeMax;
        for (int i = 0; i < bodySegments.Count; i++)
        {
            GameObject segment = bodySegments[i];
            segment.GetComponent<BoxCollider>().isTrigger = true;
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
    private void AddSegment(int count = 1)
    {
        for (int i = 0; i < count; i++)
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
    }

      public int AddSegmenetsForTest(int count = 1) 
        {
            List<GameObject> snakeParts  = new List<GameObject>();

            for (int i = 0; i < count; i++)
            {
           snakeParts.Add(snakeBodyPrefab);
            }
            return snakeParts.Count;
        }


        //increase speed when food is consumed
        private void IncreaseSpeed()
    {
        if (moveSpeed < maxSpeed)
        {
            moveSpeed += increaseSpeedAmount;
            if (moveSpeed > maxSpeed) moveSpeed = maxSpeed;
            segmentUpdateTimeMax = 1 / moveSpeed; // scale segment update with speed to avoid large gaps between body segments at high speeds
        }
    }

    public float maxSnakeSpeed()
    {
        return maxSpeed; 
    }
    public float IncreaseSnakeSpeed()
    {
          
            if (moveSpeedForTest < maxSpeed)
            {
                moveSpeedForTest += increaseSpeedAmount;
                if (moveSpeedForTest > maxSpeed) moveSpeedForTest = maxSpeed;
                segmentUpdateTimeMax = 1 / moveSpeedForTest; // scale segment update with speed to avoid large gaps between body segments at high speeds
            }
            return moveSpeedForTest;
    }


        private void EatFood()
    {
        ScoreManager.instance.AddPoints(); // Interaction with ScoreManager
        AddSegment(3);
        IncreaseSpeed();
            FoodConsumedForTest();

        }

        public void EatFoodForTest ()
        {
      
            IncreaseSnakeSpeed();
            AddSegmenetsForTest(3);
            FoodConsumedForTest();

        }

        public void ResetSnake()
        {
            for (int i = 0; i <bodySegments.Count; i++)
            {
                Destroy(bodySegments[i].gameObject);
            }
            bodySegments.Clear();
            moveSpeed = 0;
            maxTiltAroundX = 0;
			maxTiltAroundY = 0;

		}


 public void OnTriggerEnter (Collider other)
    {

        if (other.tag == "Food")
        {
            EatFood();
        }
        else if (other.tag == "Obstacle")
        {
                ResetSnake();
             
            GameOver.Setup();
        }
    }

 public bool FoodConsumedForTest ()
        {

            return foodConsumed = true;
        }
        

        private void OnTriggerExit(Collider other)
    {

        if (other.tag == "Out of Bounds")
        {
				ResetSnake();
				GameOver.Setup();
        }   
    }

}
}
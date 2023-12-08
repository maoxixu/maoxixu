// Import necessary libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Define the class named movementvert, which inherits from MonoBehaviour
public class movementvert : MonoBehaviour
{
    // Declare float variables for two different movement speeds
    float moveSpeedOne;
    float moveSpeedTwo;

    // Declare a boolean variable to track the movement state
    bool isitSo;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the movement speeds and set the initial movement state
        moveSpeedOne = 7f;
        moveSpeedTwo = 7f;
        isitSo = true;
    }

    // Update is called once per frame
    void Update()
    {
        // Move the object forward based on the first movement speed
        transform.Translate(0, 0, moveSpeedOne * Time.deltaTime);

        // Check if the object's position along the z-axis is greater than or equal to 6f
        if (transform.position.z >= 6f)
        {
            // Stop the first movement speed, change the movement state, and set the second movement speed
            moveSpeedOne = 0f;
            isitSo = false;
            moveSpeedTwo = -7f;
        }

        // Check if the object's position along the z-axis is less than or equal to -8.45f
        if (transform.position.z <= -8.45f)
        {
            // Stop the second movement speed, change the movement state, and set the first movement speed
            moveSpeedTwo = 0f;
            isitSo = true;
            moveSpeedOne = 7f;
        }

        // Check if the movement state is true
        if (isitSo == true)
        {
            // Move the object forward based on the first movement speed

            transform.Translate(0, 0, moveSpeedOne * Time.deltaTime);

        }

        if (isitSo == false)
        {

            transform.Translate(0, 0, moveSpeedTwo * Time.deltaTime);

        }



    }
}

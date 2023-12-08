using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement2 : MonoBehaviour
{
    // Movement speeds for two different directions along the x-axis
    float moveSpeedOne;
    float moveSpeedTwo;

    // Boolean flag to determine the direction of movement
    bool isitSo;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize movement speeds and set initial direction to true
        moveSpeedOne = 3f;
        moveSpeedTwo = 3f;
        isitSo = true;
    }

    // Update is called once per frame
    void Update()
    {
        // Check the position of the GameObject along the x-axis
        if (transform.position.x >= 19f)
        {
            // If position is greater than or equal to 19, stop movement in one direction
            moveSpeedOne = 0f;
            isitSo = false;
            // Start movement in the opposite direction
            moveSpeedTwo = -3f;
        }

        // Check the position of the GameObject along the x-axis
        if (transform.position.x <= 16f)
        {
            // If position is less than or equal to 16, stop movement in the other direction
            moveSpeedTwo = 0f;
            isitSo = true;
            // Start movement in the original direction
            moveSpeedOne = 3f;
        }

        // Check the direction flag to determine which direction to move
        if (isitSo == true)
        {
            // Move in one direction along the x-axis
            transform.Translate(moveSpeedOne * Time.deltaTime, 0, 0);
        }

        // Check the direction flag to determine which direction to move
        if (isitSo == false)
        {
            // Move in the other direction along the x-axis
            transform.Translate(moveSpeedTwo * Time.deltaTime, 0, 0);
        }
    }
}

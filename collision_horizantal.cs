// Import necessary libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Define the class named collision_horizantal, which inherits from MonoBehaviour
public class collision_horizantal : MonoBehaviour
{
    // Declare a float variable named speed
    float speed;

    // Declare a boolean variable named isitcollidhorizan, and expose it in the Unity Inspector
    [SerializeField] bool isitcollidhorizan;

    // Start is called before the first frame update
    void Start()
    {
        // Call the setvalue method to initialize the speed and isitcollidhorizan values
        setvalue();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if isitcollidhorizan is false
        if (isitcollidhorizan == false)
        {
            // Move the object to the right based on the speed and deltaTime
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }

        // Check if isitcollidhorizan is true
        if (isitcollidhorizan == true)
        {
            // Move the object to the left based on the speed and deltaTime
            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }
    }

    // Called when a collision occurs
    void OnCollisionEnter(Collision other)
    {
        // Check if the collided object has the tag "WallWest" and isitcollidhorizan is true
        if (other.gameObject.tag == "WallWest" && isitcollidhorizan == true)
        {
            // Set isitcollidhorizan to false
            isitcollidhorizan = false;

            // Reset the object's position
            transform.position += new Vector3(0, 0, 0);
        }

        // Check if the collided object has the tag "Hit" and isitcollidhorizan is true
        if (other.gameObject.tag == "Hit" && isitcollidhorizan == true)
        {
            // Set isitcollidhorizan to false
            isitcollidhorizan = false;

            // Reset the object's position
            transform.position += new Vector3(0, 0, 0);
        }

        // Check if the collided object has the tag "WallEast"
        if (other.gameObject.tag == "WallEast")
        {
            // Check if isitcollidhorizan is false
            if (isitcollidhorizan == false)
            {
                // Set isitcollidhorizan to true
                isitcollidhorizan = true;

                // Reset the object's position
                transform.position += new Vector3(0, 0, 0);
            }
        }

        // Check if the collided object has the tag "Hit2" and isitcollidhorizan is false
        if (other.gameObject.tag == "Hit2" && isitcollidhorizan == false)
        {
            // Set isitcollidhorizan to true
            isitcollidhorizan = true;

            // Reset the object's position
            transform.position += new Vector3(0, 0, 0);
        }
    }

    // Method to initialize speed and isitcollidhorizan
    void setvalue()
    {
        // Set the speed to 3f
        speed = 3f;

        // Set isitcollidhorizan to false
        isitcollidhorizan = false;
    }
}

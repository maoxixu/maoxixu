// Import necessary libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Define the class named Dropper_2, which inherits from MonoBehaviour
public class Dropper_2 : MonoBehaviour
{
    // Declare variables for the MeshRenderer and Rigidbody components
    MeshRenderer renderer2;
    Rigidbody rigidBuddy;

    // Expose a float variable in the Unity Inspector, indicating the time to wait before dropping
    [SerializeField] float timetoWait = 18f;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the MeshRenderer and Rigidbody components
        renderer2 = GetComponent<MeshRenderer>();
        rigidBuddy = GetComponent<Rigidbody>();

        // Initially, disable the mesh renderer and gravity for the rigidbody
        renderer2.enabled = false;
        rigidBuddy.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the current time has exceeded the specified time to wait
        if (Time.time > timetoWait)
        {
            // Enable the mesh renderer and gravity for the rigidbody, making the object visible and fall
            renderer2.enabled = true;
            rigidBuddy.useGravity = true;
        }
    }
}

// Import necessary libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Define the class named Dropper, which inherits from MonoBehaviour
public class Dropper : MonoBehaviour
{
    // Declare variables for the MeshRenderer and Rigidbody components
    MeshRenderer renderer;
    Rigidbody rigidBuddy;

    // Expose a float variable in the Unity Inspector, indicating the time to wait before dropping
    [SerializeField] float timetoWait = 4f;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the MeshRenderer and Rigidbody components
        renderer = GetComponent<MeshRenderer>();
        rigidBuddy = GetComponent<Rigidbody>();

        // Initially, disable the mesh renderer and gravity for the rigidbody
        renderer.enabled = false;
        rigidBuddy.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the current time has exceeded the specified time to wait
        if (Time.time > timetoWait)
        {
            // Enable the mesh renderer and gravity for the rigidbody, making the object visible and fall
            renderer.enabled = true;
            rigidBuddy.useGravity = true;
        }
    }
}

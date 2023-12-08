// Import necessary libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Define the class named Cylider2, which inherits from MonoBehaviour
public class Cylider2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // This method is called when the object is first created.
        // It is currently empty.
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the object around its z-axis at a rate of 200 degrees per second,
        // scaled by Time.deltaTime to ensure consistent rotation speed across different devices.
        transform.Rotate(0, 0, 200 * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score_Feedback : MonoBehaviour
{
    // Counter for the number of collisions
    int hits = 0;

    // Called when a collision occurs with another collider
    void OnCollisionEnter(Collision other)
    {
        // Check if the collided object does not have the "Hit" tag
        if (other.gameObject.tag != "Hit")
        {
            // Increment the hits counter
            hits++;
            // Log the number of collisions to the console
            Debug.Log("You bumped into a thing many times: " + hits);
        }

        // Check if the number of hits exceeds a certain threshold (e.g., 10)
        
    }
}

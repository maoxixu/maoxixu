// Import necessary libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Define the class named copyanddestroy, which inherits from MonoBehaviour
public class copyanddestroy : MonoBehaviour
{
    // Public variables accessible in the Unity Inspector
    public GameObject guyGameobject;           // Reference to the GameObject to be instantiated
    public GameObject instantiateObjectHere;   // Reference to the position where the object will be instantiated
    public GameObject newInstance;              // Reference to the newly instantiated object

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreatePrefab", 0f, 3f); //for every 3 sec will clone a newinstance
       
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the 'F' key is pressed
        if (Input.GetKeyDown(KeyCode.F))
        {
            // Call the DestroyPrefab method
            DestroyPrefab();
        }

       
    }

    // Method to instantiate a new prefab
    public void CreatePrefab()
    {
        // Get the x and y coordinates of the instantiateObjectHere position
        float instx = instantiateObjectHere.transform.position.x;
        float insty = instantiateObjectHere.transform.position.y;

        // Instantiate a new copy of the guyGameobject at the specified position and rotation
        newInstance = Instantiate(guyGameobject, new Vector3(instx, insty, 18), Quaternion.identity);
        
       
    }
   
    // Method to destroy the instantiated prefab
    public void DestroyPrefab()
    {
        // Destroy the newInstance GameObject
        Destroy(newInstance);
    }
     
}

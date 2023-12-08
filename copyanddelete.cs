// Import necessary libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Define the class named copyanddestroy, which inherits from MonoBehaviour
public class copyanddelete : MonoBehaviour
{
    // Public variables accessible in the Unity Inspector
    public GameObject guyGameobject;           // Reference to the GameObject to be instantiated
    public GameObject instantiateObjectHere;   // Reference to the position where the object will be instantiated
    public GameObject new2Instance;              // Reference to the newly instantiated object

    // Start is called before the first frame update
    void Start()
    {
        // This method is called when the object is first created.
        // It is currently empty.
            CreatePrefab();
         
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the 'F' key is pressed
        if (guyGameobject.tag == "Hit" )
        { 
            // Call the DestroyPrefab method
            DestroyPrefab();
        }

        // Check if the remainder of the current time divided by 3 is greater than 2.998
      
      
    }

    // Method to instantiate a new prefab
    public void CreatePrefab()
    {
        // Get the x and y coordinates of the instantiateObjectHere position
        float instx = instantiateObjectHere.transform.position.x;
        float insty = instantiateObjectHere.transform.position.y;

        // Instantiate a new copy of the guyGameobject at the specified position and rotation
        // newInstance = Instantiate(guyGameobject, new Vector3(instx, insty, 18), Quaternion.identity);
        new2Instance = Instantiate(guyGameobject, new Vector3(instx, insty, -9), Quaternion.identity);
    }
    /* public void CreateotherPrefab()
     {
         // Get the x and y coordinates of the instantiateObjectHere position
         float instx = instantiateObjectHere.transform.position.x;
         float insty = instantiateObjectHere.transform.position.y;

         // Instantiate a new copy of the guyGameobject at the specified position and rotation

         bigInstance = instantiate(guyGameobject, new Vectors(instx, insty, 18), Quaternion.identity);
     }*/

    // Method to destroy the instantiated prefab
    public void DestroyPrefab()
    {
        // Destroy the newInstance GameObject
        Destroy(new2Instance);
    }
}

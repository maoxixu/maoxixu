using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_movement : MonoBehaviour
{
    bool isitcolliding; //declaring a boolean variable and calling it isitcolliding
    float speed_of_collision;
    // Start is called before the first frame update
    //this is where I have the option to set variable
    //also if i want code to be excute once
    void Start()
    {
        setvalue();
       

    }

    // Update is called once per frame 
    void Update()
    {   //if my boolean variable is false
        if(isitcolliding == false)
        {   
            // my game object will move 2 units to the right on the z axis
              transform.position += new Vector3(0, 0, speed_of_collision * Time.deltaTime);

        }
        // if my boolean variable is true
        if(isitcolliding ==true)
        {   // my game object will move 2 units to the left on the z axis
            transform.position += new Vector3(0, 0, -speed_of_collision * Time.deltaTime);
        }
        
    }
    //
    void OnCollisionEnter (Collision other)
    {   //if  my game object has a tag named WallNorth and my variable is false
        if(other.gameObject.tag == "WallNorth" && isitcolliding == false)
        {   //set isitcolliding to true
            isitcolliding= true;
            // I tell my game object to stop
            transform.position += new Vector3(0, 0, 0);

        }
        if (other.gameObject.tag == "Hit" && isitcolliding == false)
        {   //set isitcolliding to true
            isitcolliding = true;
            // I tell my game object to stop
            transform.position += new Vector3(0, 0, 0);

        }
        //if my game objedt has a tag named WallSouth and my variable is true
        if (other.gameObject.tag == "WallSouth" && isitcolliding == true)
        {     //set isitcolliding to false  
            isitcolliding = false;
            //i tell my game object to stops
            transform.position += new Vector3(0, 0, 0);
        }
        if (other.gameObject.tag == "Hit2" && isitcolliding == true)
        {     //set isitcolliding to false  
            isitcolliding = false;
            //i tell my game object to stops
            transform.position += new Vector3(0, 0, 0);
        }
    }
    void setvalue()
    {
        speed_of_collision = 4f;  //set speed of collision to 4
        isitcolliding = false;  // set isitcolliding to false

    }
}

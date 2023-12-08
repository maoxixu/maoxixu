using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_hitnew : MonoBehaviour
{
    // Start is called before the first frame update
  
  
        void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.tag == "Player")
            {


                GetComponent<MeshRenderer>().material.color = Color.yellow;
                gameObject.tag = "Hit";
                

            }
        }


    
}

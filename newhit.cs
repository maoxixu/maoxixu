using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newhit : MonoBehaviour
{
    // Start is called before the first frame update


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {


            GetComponent<MeshRenderer>().material.color = Color.green;
            gameObject.tag = "Hit";


        }
    }



}

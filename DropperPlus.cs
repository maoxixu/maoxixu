using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropperPlus : MonoBehaviour
{
    [SerializeField] float waitingTime;
    [SerializeField] private GameObject dropObject;


    // Start is called before the first frame update
    void Start()
    {
        waitingTime = 10f;
        dropObject = GameObject.Find("DropperPlus");

        if (Time.time > waitingTime)
        {


            Instantiate(dropObject, transform.position, Quaternion.identity);



        }

    }

    // Update is called once per frame
    void Update()
    {






    }



}

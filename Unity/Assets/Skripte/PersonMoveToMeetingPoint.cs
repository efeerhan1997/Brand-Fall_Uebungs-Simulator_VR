﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonMoveToMeetingPoint : MonoBehaviour
{
    private bool _isInsideTrigger = false;
    private int random;
    public Vector3 MeetingPoint;
    public GameObject Person;



    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            _isInsideTrigger = true;
            random = Random.Range(0, 2);

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _isInsideTrigger = false;

        }
    }

    void TransformPerson()
    {
        Person.transform.position = MeetingPoint;
    }



    // Update is called once per frame
    void Update()
    {


        if (_isInsideTrigger)
        {
            if (OVRInput.Get(OVRInput.Button.One))
            {
                if (random == 0)
                {

                    GetComponent<Renderer>().material.color = Color.green;
                    Invoke("TransformPerson", 5);

                }

                if (random == 1)
                {
                    GetComponent<Renderer>().material.color = Color.red;
                }
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorUpDown : MonoBehaviour
{
    public Animator _animator;
    public Animator Elevator_door_EG;
    public Animator Elevator_door_OG;
    private bool _isInsideTrigger = false;

    private bool _isUp = false;




    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            _isInsideTrigger = true;

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _isInsideTrigger = false;

        }
    }


    // Update is called once per frame
    void Update()
    {

        if (_isInsideTrigger)
        {
            if (OVRInput.Get(OVRInput.Button.One))
            {
                _isUp = !_isUp;

                _animator.SetBool("up", _isUp);

                if (_isUp == true)
                {
                    Elevator_door_EG.SetBool("open", false);
                    Elevator_door_OG.SetBool("open", true);
                }
                else
                {
                    Elevator_door_EG.SetBool("open", true);
                    Elevator_door_OG.SetBool("open", false);
                }

            }                                                     
        }
    }
}

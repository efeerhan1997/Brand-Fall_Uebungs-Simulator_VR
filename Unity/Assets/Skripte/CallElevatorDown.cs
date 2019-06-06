using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallElevatorDown : MonoBehaviour
{
    public Animator _animator;
    public Animator Elevator_door_EG;
    public Animator Elevator_door_OG;

    private bool _isInsideTrigger = false;

    private bool _isUp = false;

    // Use this for initialization


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

	
	void openDoorEG()
	{
		Elevator_door_EG.SetBool("open", true);
	}
    // Update is called once per frame
    void Update()
    {

        if (_isInsideTrigger)
        {
            if (OVRInput.Get(OVRInput.Button.One))
            {
				GetComponent<Renderer>().material.color = Color.green;				
                Invoke("openDoorEG",6);
                Elevator_door_OG.SetBool("open", false);
                _animator.SetBool("up", false);
					
            }
        }
    }
}

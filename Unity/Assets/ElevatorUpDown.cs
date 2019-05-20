using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorUpDown : MonoBehaviour
{
    public Animator _animator;

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
            if (Input.GetKeyDown(KeyCode.E))
            {
                _isUp = !_isUp;
                _animator.SetBool("up", _isUp);
            }
        }
    }
}

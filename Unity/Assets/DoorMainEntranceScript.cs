using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMainEntranceScript : MonoBehaviour
{
    private Animator _animator;

    private bool _isInsideTrigger = false;

    private bool _isopen = false;

    // Use this for initialization
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

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
                _isopen = !_isopen;
                _animator.SetBool("open", _isopen);
            }
        }
    }
}

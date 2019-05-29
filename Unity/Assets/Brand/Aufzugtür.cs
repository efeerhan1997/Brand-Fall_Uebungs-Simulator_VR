using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aufzugtür : MonoBehaviour
{
    private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent <Animator>();
    }

    void OnTriggerEnter(Collider other)
    { 
        if (other.tag == "Player")
    _animator.SetBool("open",true); 
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            _animator.SetBool("open",false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

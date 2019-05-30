using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telephone_Text : MonoBehaviour
{
    public AudioSource Telephone_audio;
    private bool _isInsideTrigger = false;
    private bool _isOn = false;

    // Start is called before the first frame update
    void Start()
    {
        Telephone_audio = GetComponent<AudioSource>();

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
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
            if(OVRInput.Get(OVRInput.Button.One))
            {
                _isOn = !_isOn;

                if (_isOn == true)
                {
                    Telephone_audio.Play();
                }

                else
                {
                    Telephone_audio.Stop();
                }
                

            }
        }
    }
}

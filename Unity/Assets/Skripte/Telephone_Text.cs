using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telephone_Text : MonoBehaviour
{
    private AudioSource Telephone_audio;
    public AudioSource Telephone_ring;

    private bool _isInsideTrigger = false;
    private bool _isOn = true;
   

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

                if (Telephone_ring.isPlaying == true && _isOn == false)
                {
                    Telephone_ring.Stop();
                    Telephone_audio.Play();                                   
                }

                else if (Telephone_ring.isPlaying == false && _isOn == true)
                {
                    Telephone_audio.Stop();
                }
            }
            
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telephone_Text : MonoBehaviour
{
    private AudioSource Telephone_audio;
    public AudioSource Telephone_ring;
	public AudioSource FireAlarmEG;
	public AudioSource FireAlarmOG;
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
        if(Telephone_ring.isPlaying == true)
        {
            GetComponent<Renderer>().material.color = Color.red;
        }

        if (_isInsideTrigger)
        {
            if(OVRInput.Get(OVRInput.Button.One))
            {
                

                if (Telephone_ring.isPlaying == true && _isOn == false)
                {
                    Telephone_ring.Stop();
                    FireAlarmEG.Stop();
					FireAlarmOG.Stop();
					Telephone_audio.Play();
                    _isOn = !_isOn;
					GetComponent<Renderer>().material.color = Color.green;
                }

                else if (Telephone_ring.isPlaying == false && _isOn == true)
                {
                    Telephone_audio.Stop();
					FireAlarmEG.Play();
					FireAlarmOG.Play();
                    _isOn = !_isOn;
                }
            }
            
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telephone_Text : MonoBehaviour
{
    public AudioSource Telephone_audio;
    public AudioSource Telephone_ring;

    private bool _isInsideTrigger = false;
    private bool _isOn = false;
    private int RandomTime;

    // Start is called before the first frame update
    void Start()
    {
        RandomTime = Random.Range(15, 31);
        Debug.Log(RandomTime);
        //Telephone_audio = GetComponent<AudioSource>();
        //Telephone_ring = GetComponent<AudioSource>();
        Invoke("StartTelephone", RandomTime);
    }

    void StartTelephone()
    {
        Telephone_ring.Play();
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
                Telephone_ring.Stop();
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

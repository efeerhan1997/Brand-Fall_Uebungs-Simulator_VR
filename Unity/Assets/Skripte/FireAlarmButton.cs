using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAlarmButton : MonoBehaviour
{
    public AudioSource FireAlarmEG;
    public AudioSource FireAlarmOG;
    public AudioSource Telephone_ring;

    private bool _isInsideTrigger = false;
    

    // Start is called before the first frame update
   
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
                if (FireAlarmEG.isPlaying == false)
                {
                    FireAlarmEG.Play();
                    FireAlarmOG.Play();
                    Telephone_ring.Play();
                }
            }
        }
    }
}

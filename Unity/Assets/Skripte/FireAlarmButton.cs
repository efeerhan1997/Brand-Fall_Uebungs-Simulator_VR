using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAlarmButton : MonoBehaviour
{
    private AudioSource FireAlarm;
    public AudioSource Telephone_ring;

    private bool _isInsideTrigger = false;
    private bool _isOn = false;

    // Start is called before the first frame update
    private void Start()
    {
        FireAlarm = GetComponent<AudioSource>();
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
            if (OVRInput.Get(OVRInput.Button.One))
            {
               
                FireAlarm.Stop();
                Telephone_ring.Stop();


                FireAlarm.Play();
                Telephone_ring.Play();
            }
        }
    }
}

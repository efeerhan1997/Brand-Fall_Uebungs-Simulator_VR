using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTETHAN : MonoBehaviour
{
	public Animator _animator;
    private bool _isInsideTrigger = false;
	//private bool _isOut = false;

	//public Material matofobject;
	//public Color newcolor;
	//public KeyCode changecolor;

	private int random;


	
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            _isInsideTrigger = true;
			random = Random.Range(0,2);
			Debug.Log(random);
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
				if (random == 0)
				{
					GetComponent<Renderer> ().material.color = Color.green;
					_animator.SetBool("out", true);
					
				}

				if (random == 1)  
				{
					GetComponent<Renderer> ().material.color = Color.red;
				}
			}
		}	
	}
}

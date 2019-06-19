using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ElevatorUpDown : MonoBehaviour
{
    public Animator _animator;
    public Animator Elevator_door_EG;
    public Animator Elevator_door_OG;
    public AudioSource FireAlarm;
    private int RandomCrash;
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

    void ChangeColorBack()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }

    void ElevatorCrash()
    {
        Debug.Log("Aufzug ist abgestürzt!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

// Update is called once per frame
    void Update()
    {
        if (_isInsideTrigger)
        {
            if (OVRInput.Get(OVRInput.Button.One))
            {
                GetComponent<Renderer>().material.color = Color.green;
                Invoke("ChangeColorBack", 10);

                _isUp = !_isUp;

                if (FireAlarm.isPlaying == true)
                {
                    RandomCrash = Random.Range(0, 2);
                    if (RandomCrash == 0)
                    {
                        Invoke("ElevatorCrash", 5);
                    }
                    else
                    {
                        _animator.SetBool("up", _isUp);

                        if (_isUp == true)
                        {
                            Elevator_door_EG.SetBool("open", false);
                            Elevator_door_OG.SetBool("open", true);
                        }
                        else
                        {
                            Elevator_door_EG.SetBool("open", true);
                            Elevator_door_OG.SetBool("open", false);
                        }
                    }

                }

                else
                {
                    _animator.SetBool("up", _isUp);

                    if (_isUp == true)
                    {
                        Elevator_door_EG.SetBool("open", false);
                        Elevator_door_OG.SetBool("open", true);
                    }
                    else
                    {
                        Elevator_door_EG.SetBool("open", true);
                        Elevator_door_OG.SetBool("open", false);
                    }
                }


            }
        }
    }

}


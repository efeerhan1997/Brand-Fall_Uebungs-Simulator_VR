﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feuer : MonoBehaviour
{	public AudioSource FireAlarm;
    public bool isDamaging;
    public float damage = 10; //10 Schaden jede Sekunde

    private void OnTriggerStay(Collider col)
    {	
		if(FireAlarm.isPlaying == true)
		{
			if (col.tag == "Player")
			{
				col.SendMessage((isDamaging) ? "TakeDamage" : "HealDamage", Time.deltaTime * damage);
			}
            
		}
        
    }


}

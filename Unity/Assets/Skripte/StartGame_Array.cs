using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame_Array : MonoBehaviour
{
    public Vector3[] FirePosition = new Vector3[7];
	public Vector3[] PlayerPosition = new Vector3[4];
	public Vector3[] TelephonePosition = new Vector3[4];

    public AudioSource FireAlarmEG;
    public AudioSource FireAlarmOG;
    public AudioSource TelephoneRing;

    public GameObject Fire;
	public GameObject Player;
	public GameObject Telephone;
	private int RandomScene;
    private int RandomTime;
    private int RandomFirePosition;
	private int RandomPlayerPosition;


 
   
 
	void Awake()
	{
        RandomTime = Random.Range(15, 45);
        RandomScene = Random.Range(0, 2);
        if (RandomScene == 0)
        {
            Invoke("AlarmIsOnAtSceneStart", RandomTime);
            Debug.Log("Feueralarm löst selbst aus nach" + RandomTime + " Sekunden");
        }

        if (RandomScene == 1)
        {
            Debug.Log("Feueralarm muss selbst ausgelöst werden");
        }
    
		RandomFirePosition = Random.Range(0,7);
		Debug.Log("Feuerposition" + RandomFirePosition);
		Debug.Log(FirePosition[RandomFirePosition]);	
		Fire.transform.position = FirePosition[RandomFirePosition];
		

		RandomPlayerPosition = Random.Range(0,4);
		Debug.Log("Playerposition" + RandomPlayerPosition);
		Debug.Log(FirePosition[RandomPlayerPosition]);	
		Player.transform.position = PlayerPosition[RandomPlayerPosition];

		Telephone.transform.position = TelephonePosition[RandomPlayerPosition];
    }

    void AlarmIsOnAtSceneStart()
    {
        FireAlarmEG.Play();
        FireAlarmOG.Play();
        TelephoneRing.Play();
    }
}

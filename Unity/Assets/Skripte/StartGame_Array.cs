using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame_Array : MonoBehaviour
{
    public Vector3[] FirePosition = new Vector3[7];
	public Vector3[] PlayerPosition = new Vector3[4];
	public Vector3[] TelephonePosition = new Vector3[4];
    public Vector3[] PersonEGPosition = new Vector3[5];
    public Vector3[] PersonGroupEGPosition = new Vector3[5];
    public Vector3[] PersonOGPosition = new Vector3[5];
    public Vector3[] PersonGroupOGPosition = new Vector3[5];

    public AudioSource FireAlarmEG;
    public AudioSource FireAlarmOG;
    public AudioSource TelephoneRing;

    public GameObject Fire;
	public GameObject Player;
	public GameObject Telephone;
    public GameObject PersonEG;
    public GameObject PersonGroupEG;
    public GameObject PersonOG;
    public GameObject PersonGroupOG;

    private int RandomScene;
    private int RandomTime;
    private int RandomFirePosition;
	private int RandomPlayerPosition;
    private int RandomPersonEGPosition;
    private int RandomPersonGroupEGPosition;
    private int RandomPersonOGPosition;
    private int RandomPersonGroupOGPosition;



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

        RandomPersonEGPosition = Random.Range(0, 5);
        Debug.Log("PersonEG Position" + RandomPersonEGPosition);
        Debug.Log(PersonEGPosition[RandomPersonEGPosition]);
        PersonEG.transform.position = PersonEGPosition[RandomPersonEGPosition];

        RandomPersonGroupEGPosition = Random.Range(0, 5);
        Debug.Log("PersonGroupEG Position" + RandomPersonGroupEGPosition);
        Debug.Log(PersonGroupEGPosition[RandomPersonGroupEGPosition]);
        PersonGroupEG.transform.position = PersonGroupEGPosition[RandomPersonGroupEGPosition];

        RandomPersonOGPosition = Random.Range(0, 5);
        Debug.Log("PersonOG Position" + RandomPersonOGPosition);
        Debug.Log(PersonOGPosition[RandomPersonOGPosition]);
        PersonOG.transform.position = PersonOGPosition[RandomPersonOGPosition];

        RandomPersonGroupOGPosition = Random.Range(0, 5);
        Debug.Log("PersonGroupOG Position" + RandomPersonGroupOGPosition);
        Debug.Log(PersonGroupOGPosition[RandomPersonGroupOGPosition]);
        PersonGroupOG.transform.position = PersonGroupOGPosition[RandomPersonGroupOGPosition];
   
    }

    void AlarmIsOnAtSceneStart()
    {
        FireAlarmEG.Play();
        FireAlarmOG.Play();
        TelephoneRing.Play();
    }
}

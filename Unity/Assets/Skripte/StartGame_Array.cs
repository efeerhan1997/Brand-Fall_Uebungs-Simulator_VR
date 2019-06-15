using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame_Array : MonoBehaviour
{
    public Vector3[] FirePosition = new Vector3[7];
	public Vector3[] PlayerPosition = new Vector3[4];
	public Vector3[] TelephonePosition = new Vector3[4];
    public Vector3[] PersonEG1Position = new Vector3[5];
    public Vector3[] PersonEG2Position = new Vector3[5];
    public Vector3[] PersonOG1Position = new Vector3[5];
    public Vector3[] PersonOG2Position = new Vector3[5];

    public AudioSource FireAlarmEG;
    public AudioSource FireAlarmOG;
    public AudioSource TelephoneRing;

    public GameObject Fire;
	public GameObject Player;
	public GameObject Telephone;
    public GameObject PersonEG1;
    public GameObject PersonEG2;
    public GameObject PersonOG1;
    public GameObject PersonOG2;

    private int RandomScene;
    private int RandomTime;
    private int RandomFirePosition;
	private int RandomPlayerPosition;
    private int RandomPersonEG1Position;
    private int RandomPersonEG2Position;
    private int RandomPersonOG1Position;
    private int RandomPersonOG2Position;



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

        Debug.Log("Telephoneposition" + RandomPlayerPosition);
        Debug.Log(TelephonePosition[RandomPlayerPosition]);
        Telephone.transform.position = TelephonePosition[RandomPlayerPosition];

        RandomPersonEG1Position = Random.Range(0, 5);
        Debug.Log("PersonEG1 Position " + RandomPersonEG1Position);
        Debug.Log(PersonEG1Position[RandomPersonEG1Position]);
        PersonEG1.transform.position = PersonEG1Position[RandomPersonEG1Position];

        RandomPersonEG2Position = Random.Range(0, 5);
        Debug.Log("PersonEG2 Position " + RandomPersonEG2Position);
        Debug.Log(PersonEG2Position[RandomPersonEG2Position]);
        PersonEG2.transform.position = PersonEG1Position[RandomPersonEG2Position];

        RandomPersonOG1Position = Random.Range(0, 5);
        Debug.Log("PersonOG1 Position " + RandomPersonOG1Position);
        Debug.Log(PersonOG1Position[RandomPersonOG1Position]);
        PersonOG1.transform.position = PersonOG1Position[RandomPersonOG1Position];

        RandomPersonOG2Position = Random.Range(0, 5);
        Debug.Log("PersonOG2 Position " + RandomPersonOG2Position);
        Debug.Log(PersonOG2Position[RandomPersonOG2Position]);
        PersonOG2.transform.position = PersonOG2Position[RandomPersonOG2Position];
   
    }

    void AlarmIsOnAtSceneStart()
    {
        FireAlarmEG.Play();
        FireAlarmOG.Play();
        TelephoneRing.Play();
    }
}

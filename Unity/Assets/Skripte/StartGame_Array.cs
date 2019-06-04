using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame_Array : MonoBehaviour
{
    public Vector3[] Arrayposition = new Vector3[4];
	public Vector3 position0;
	public Vector3 position1;
	public Vector3 position2;
	public Vector3 position3;
    public AudioSource FireAlarmEG;
    public AudioSource FireAlarmOG;
    public AudioSource TelephoneRing;

    public GameObject Fire;
	private int RandomScene;
    private int RandomTime;
    private int RandomFire;


 
   
 
	void Awake()
	{
        RandomTime = Random.Range(15, 45);
        RandomScene = Random.Range(0, 2);
        if (RandomScene == 0)
        {
            Invoke("AlarmIsOnAtSceneStart", RandomTime);
            Debug.Log(RandomTime);
            Debug.Log(RandomScene);
        }

		RandomFire = Random.Range(0,4);
		Debug.Log(RandomFire);
		Arrayposition[0]= position0;
		Arrayposition[1]= position1;
		Arrayposition[2]= position2;
		Arrayposition[3]= position3;


		
		Fire.transform.position = new Vector3(position2);
		Debug.Log(Arrayposition[RandomFire]);
        
    }

    void AlarmIsOnAtSceneStart()
    {
        FireAlarmEG.Play();
        FireAlarmOG.Play();
        TelephoneRing.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

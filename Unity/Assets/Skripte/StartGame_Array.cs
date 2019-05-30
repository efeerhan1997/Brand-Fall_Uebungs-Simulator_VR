using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame_Array : MonoBehaviour
{
	public Vector3[] Arrayposition;
	public Vector3 position0;
	public Vector3 position1;
	public Vector3 position2;
	public Vector3 position3;

	private int random;


    // Start is called before the first frame update
   
    
	//random = Random.Range(0,4);
	void Awake()
	{	

		random = Random.Range(0,4);
		Debug.Log(random);
		Arrayposition[0]= position0;
		Arrayposition[1]= position1;
		Arrayposition[2]= position2;
		Arrayposition[3]= position3;


		
		transform.position = Arrayposition[random];
		Debug.Log(Arrayposition[random]);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

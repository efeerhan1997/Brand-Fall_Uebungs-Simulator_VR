using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material standardMaterial;
    public Material changedMaterial;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changeTo(string color)
    {
        if (color.Equals("darkgray"))
        {
            GetComponent<Renderer>().material = standardMaterial;
        }
        if (color.Equals("grey"))
        {
            GetComponent<Renderer>().material = changedMaterial;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerByLooking : MonoBehaviour
{
    public Transform direction;
    public float maxHitDistance = 10;
    private ChangeMaterial changeMaterial;
    private bool selecting = false;
    private GameObject lastObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkHit();
    }
    private void checkHit()
    {
        RaycastHit hit;
        if (Physics.Raycast (direction.position, direction.forward, out hit, maxHitDistance))
            if (hit.collider.gameObject.tag.Equals("Target"))
            {
                if (lastObject != null && !hit.collider.gameObject.Equals(lastObject))
                {
                    deselect();
                }
                if (!selecting)
                {
                select(hit.collider.gameObject);
                }
                 //hit interisting object
            }
        else
            {
                if (!selecting)
                {
                deselect();
                }
                //hit object without "Target" tag
            }
        else
        {
            deselect();
             //hit no object
        }
    }

    private void select (GameObject hitObject)
    {
        selecting = true;
        changeMaterial = hitObject.GetComponent<ChangeMaterial>();
        changeMaterial.changeTo("grey");
        lastObject = hitObject;
    }
    private void deselect ()
    {
        selecting = false;
        if (changeMaterial != null)
        {
            changeMaterial.changeTo("darkgray");
        }
    }
}

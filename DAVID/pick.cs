using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pick : MonoBehaviour
{
    float tf = 1000f;
    Vector3 objpos;
    float dist;

    public GameObject item;
 
    public GameObject tempP;
    public bool isheld = false;
 
    void Update()
    {
        dist = Vector3.Distance(this.transform.position, tempP.transform.position);
        if(dist >= 5f)
        {
            isheld = false;
        }

        if(isheld == true)
        {
            item.GetComponent<Rigidbody>().velocity = Vector3.zero;
            item.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            item.transform.SetParent(tempP.transform);

            if (Input.GetMouseButtonDown(1))
            {
                item.GetComponent<Rigidbody>().AddForce(tempP.transform.forward * tf);
                isheld = false;

            }

        }
        else
        {
            objpos = this.transform.position;
            item.transform.SetParent(null);
            item.GetComponent<Rigidbody>().useGravity = true;
            item.transform.position = objpos;
        }
    }

    void OnMouseDown()
    {
        if (dist <= 5f)
        { 
            isheld = true;
            this.GetComponent<Rigidbody>().useGravity = false;
            this.GetComponent<Rigidbody>().detectCollisions = true;
        }
    }

    void OnMouseUp()
    {

        isheld = false;
    }
}

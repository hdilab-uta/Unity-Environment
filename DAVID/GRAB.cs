using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GRAB : MonoBehaviour
{
    public Transform dest;

    void OnMouseDown()
    {
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = dest.position;
        this.transform.parent = GameObject.Find("guide").transform;
        
    }

    void OnMouseUp()
    {
        GetComponent<Rigidbody>().useGravity = true;
        this.transform.position = dest.position;
        this.transform.parent = null;

    }

    void Update()
    {
        
    }
}

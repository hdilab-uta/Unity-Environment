using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hipop : MonoBehaviour
{
    private bool fwd;
    private int count;
    // Start is called before the first frame update
    void Start()
    {
        fwd = true;
        count = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(fwd == true)
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
            count += 1;
            if(count > 10)
            {
                fwd = false;
                count = 0;
            }
            

        }
        else
        {
            transform.Translate(Vector3.back * Time.deltaTime);
            count += 1;
            if(count > 10)
            {
                fwd = true;
                count = 0;
            }
            
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obvrmvmt : MonoBehaviour
{
    public CharacterController controller;
    public float sped = 12f;


    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * sped *Time.deltaTime);
        
    }
}

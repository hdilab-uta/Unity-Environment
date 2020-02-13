using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouselook : MonoBehaviour
{
    public float msen = 1000f;
    public Transform playerBod;
    float xrot = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * msen * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * msen * Time.deltaTime;

        playerBod.Rotate(Vector3.up * mouseX);
        xrot -= mouseY;
        xrot = Mathf.Clamp(xrot, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xrot, 0f, 0f);


    }
}

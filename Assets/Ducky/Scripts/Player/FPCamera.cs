using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR;

public class FPCamera : MonoBehaviour
{
   
    public float turnSpeed = 4.0f;
    public float Speed = 2.0f;
    public float minTurnAngle = -90.0f;
    public float maxTurnAngle = 90.0f;
    float rotateX;

    public bool CutSceane = false;
    void Update ()
    {
        Cursor.lockState = CursorLockMode.Locked;

        if (!CutSceane)
        {
            mousestuff();
            kbstuff();
        }
    }
    void mousestuff ()
    {
        float rotateY = Input.GetAxis("Mouse X") * turnSpeed;
        rotateX += Input.GetAxis("Mouse Y") * turnSpeed;
        rotateX = Mathf.Clamp(rotateX, minTurnAngle, maxTurnAngle);
        transform.eulerAngles = new Vector3(-rotateX, transform.eulerAngles.y + rotateY, 0);
    }
    void kbstuff ()
    {
        Vector3 direction = new Vector3(0, 0, 0);
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");
        transform.Translate(direction * Speed * Time.deltaTime);
    }
}

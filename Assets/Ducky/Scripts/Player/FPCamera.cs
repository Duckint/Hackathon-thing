using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR;

public class FPCamera : MonoBehaviour
{
    Camera fpcamera;
    private float turnspeed;

    private float rotateX;
    // Start is called before the first frame update
    void Start()
    {
        fpcamera = GetComponent<Camera>();
       
        
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;
        turnspeed = 0.5f;
        float rotateY = Input.GetAxis("Mouse X") * turnspeed;
        rotateX += Input.GetAxis("Mouse Y") * turnspeed;

        transform.eulerAngles = new Vector3(-rotateX, transform.eulerAngles.y + rotateY, 0);
    }
}

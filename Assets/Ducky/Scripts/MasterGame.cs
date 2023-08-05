using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MasterGame : MonoBehaviour
{
    public bool playcutscene = false;
    public bool cutscene1 = false;
    public bool cutscene2 = false;

    public void Cutscenes()
    {
        FPCamera fpobj = new FPCamera();
        if (cutscene1)
        {
            //false is true, true is false dont ask it just is
            playcutscene = false;
            GameObject CameraFollow;
            CameraFollow = GameObject.Find("AcameraBone");
            transform.position = CameraFollow.transform.position;
            transform.rotation = CameraFollow.transform.rotation;
        }
        if (cutscene2)
        {
            
        }
    }
    /*void Start()
    {
        
    }
    void Update()
    {
        
    }*/
}

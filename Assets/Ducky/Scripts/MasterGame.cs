using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MasterGame : MonoBehaviour
{
    public bool dontPlaycutscene = false;
    bool cutscene1 = true;
    public bool cutscene2 = false;

    public void Cutscenes()
    {
        if (cutscene1)
        {
            //false is true, true is false dont ask it just is
            dontPlaycutscene = false;
            GameObject CameraFollow;
            CameraFollow = GameObject.Find("AcameraBone");
            transform.position = new Vector3(CameraFollow.transform.position.x + 0.01f, CameraFollow.transform.position.y + 0.1f,
                CameraFollow.transform.position.z - 0.3f);
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

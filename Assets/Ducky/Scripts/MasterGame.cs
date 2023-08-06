using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MasterGame : MonoBehaviour
{
    public bool InMenu = true;
    public bool dontPlaycutscene = true;
    public bool cutscene1 = false;
    public bool cutscene2 = false;
    private double timepassed = 0;
    private bool testis;

    public void Cutscenes()
    {
        if (cutscene1)
        {
            //false is true, true is false dont ask it just is
            GameObject arms = GameObject.FindGameObjectWithTag("Cutscene Model");
            GameObject cube = GameObject.Find("Touchingcube");
            timepassed += Time.deltaTime;
            GameObject CameraFollow;

            if (testis)
            {
                
                arms.GetComponent<Animator>().SetTrigger("otrig");
                testis = false;

            }
            CameraFollow = GameObject.Find("AcameraBone");
            transform.position = new Vector3(CameraFollow.transform.position.x + 0.01f,CameraFollow.transform.position.y + 0.1f, CameraFollow.transform.position.z - 0.3f);
            transform.rotation = CameraFollow.transform.rotation;
            if (timepassed >= 20)
            {
                dontPlaycutscene = true;
                Destroy(arms);
            }
        }
        if (cutscene2)
        {
            
        }
    }

    private void OnCollisionStay(Collision other)
    {
        
        if (other.gameObject.name == "Touchingcube" )
        {
            Debug.Log("im not gay");
            dontPlaycutscene = false;
            cutscene1 = true;
            testis = true;
            //unity go die
        }
    }
    /*void Start()
    {
        
    }
    void Update()
    {
        
    }*/
}

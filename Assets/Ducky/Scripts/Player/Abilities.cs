using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilities : MonoBehaviour
{
    private GameObject fun2;
    private Animator fun;
    private void Start()
    {
        fun2 = GameObject.Find("Arms");
        fun = GetComponent<Animator>();
    }
    
    private void OnCollisionStay(Collision collide)
    {

        if (collide.gameObject.tag == "Enemy")
        {
            if (Input.GetMouseButton(0))
            {
                fun2.GetComponent<Animator>().SetTrigger("punchtrig");
                Destroy(collide.gameObject);
            }
            
        } 
    }
    
}

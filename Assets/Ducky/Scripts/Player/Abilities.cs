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

    private void Update()
    {
        if (Input.GetKey(KeyCode.K))
        {
            fun2.GetComponent<Animator>().SetTrigger("punchtrig");
        }
    }
    private void OnCollisionStay(Collision collide)
    {

        if (collide.gameObject.tag == "Enemy")
        {
            if (Input.GetMouseButton(0))
            {
                Destroy(collide.gameObject);
            }
            
        } 
    }
    
}

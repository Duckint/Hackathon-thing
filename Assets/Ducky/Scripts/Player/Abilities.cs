using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilities : MonoBehaviour
{
    private GameObject fun2;
    private Animator fun;
    private BoxCollider boxx;
    private void Start()
    {
        fun2 = GameObject.Find("Arms");
        fun = GetComponent<Animator>();
        boxx = GetComponent<BoxCollider>();
    }

    private void Update()
    {
        
        if (Input.GetKey(KeyCode.Alpha1))
        {
            fun2.GetComponent<Animator>().SetTrigger("punchtrig");
        }

        if (Input.GetKey(KeyCode.Alpha2))
        {
            
        }
    }

    private void OnCollisionStay(Collision collide)
    {
        if (collide.gameObject.tag == "Enemy")
        {
            if (fun2.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("punch") && fun2.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime > 0.4f)
            {
                Destroy(collide.gameObject);
            }
        } 
    }
    
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilities : MonoBehaviour
{
    private bool isPunching = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            isPunching = true;
        }
        else
        {
            isPunching = false;
        }
    }

    private void OnCollisionEnter(Collision collide)
    {
        if (collide.gameObject.tag == "Enemy")
        {
            if (isPunching)
            {
                Destroy(collide.gameObject);
            }
        } 
    }
}

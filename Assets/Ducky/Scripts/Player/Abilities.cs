using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilities : MonoBehaviour
{
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

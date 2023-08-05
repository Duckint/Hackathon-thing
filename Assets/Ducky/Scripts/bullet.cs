using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private float foward = 500;
    private Rigidbody bullette;

    private void Start()
    {
        bullette = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Vector3 bulletmove = new Vector3(0, 0, 1);
        bulletmove = bulletmove.normalized * foward * Time.deltaTime;
        bullette.MovePosition(transform.position + bulletmove);
    }
    private void OnCollisionEnter(Collision bullet)
    {
        if (bullet.gameObject.tag == "Enemy")
        {
            Destroy(bullet.gameObject);
        }
    }
}

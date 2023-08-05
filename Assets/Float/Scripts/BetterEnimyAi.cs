using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterEnimyAi : MonoBehaviour
{

    public float moveSpeed = 5f;

    Rigidbody rb;
    Transform target;
    Vector3 MoveDir;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        target = GameObject.Find("Playercam").transform;
    }

    // Update is called once per frame
    private void Update()
    {
        if (target)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            //float angle = Mathf.Atan2(direction.z, direction.x) * Mathf.Rad2Deg;

            //rb.rotation = angle;
            MoveDir = direction;
        }

    }

    private void FixedUpdate()
    {
        if (target)
        {
            rb.velocity = new Vector3(MoveDir.x, transform.localPosition.y, MoveDir.z) * moveSpeed;
        }
    }
}

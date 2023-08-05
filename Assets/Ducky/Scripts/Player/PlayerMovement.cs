using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bah : MonoBehaviour
{
    Rigidbody player;
    public float speed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
       
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(horizontal * speed, 0, vertical * speed);
        player.MovePosition(transform.position + move);
    }
}

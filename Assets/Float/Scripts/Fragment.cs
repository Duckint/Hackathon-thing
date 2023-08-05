using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fragment : MonoBehaviour
{

    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {

        Player = GameObject.FindWithTag("Player");

        //Player.GetComponent<PlayerStats>().HasAngryFrag = true;

        if (Player.GetComponent<PlayerStats>().HasAngyFragment)
        {

            Debug.Log("Has");

        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {

                Player.GetComponent<PlayerStats>().HasAngyFragment = true;
                Player.GetComponent<PlayerStats>().HasFFragemt = true;
            }
        }
    }
}

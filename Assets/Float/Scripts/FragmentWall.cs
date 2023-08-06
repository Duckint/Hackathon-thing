using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FragmentWall : MonoBehaviour
{

    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
    }

    public bool CheckFragmentStates()
    {
        if (Player.GetComponent<PlayerStats>().Fragments >= 3)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Player.GetComponent<PlayerStats>().HasAngyFragment);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player"){

            if (CheckFragmentStates())
            {
                Debug.Log("YOU DID IT");
                GameObject.Destroy(GameObject.Find("MainWall"));
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class textrenderer : MonoBehaviour
{
    public TMP_Text funtext;
    void Start()
    {
        funtext = GetComponent<TMP_Text>();
    }
    void Update()
    {
            funtext.text = "bahhh";
            funtext.alignment = TextAlignmentOptions.TopLeft;
            if (Input.GetKey(KeyCode.O))
            {
                funtext.enabled = false;
            }
            else if(Input.GetKey(KeyCode.P))
            {
                funtext.enabled = true;
            }
    }
}

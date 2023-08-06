using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using UnityEditor.EventSystems;
using Unity.VisualScripting;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GuiManger : MonoBehaviour
{
    
    private Image theButton;


    private Color theColor;

    public float fadeTheThing = 0;

    private bool Fade = false;

    void Awake()
    {
        theButton = GameObject.Find("BlackScreen").GetComponent<Image>();
        theColor = GameObject.Find("BlackScreen").GetComponent<Image>().color;
    }

    private void Update()
    {
        if (Fade)
        {
            fadeTheThing = Mathf.Clamp(fadeTheThing, 0, 1);

            fadeTheThing += 1 * Time.deltaTime;

            theColor = new Color(0, 0, 0, fadeTheThing);

            theButton.color = theColor;

            if (fadeTheThing >= 1)
            {
                GameObject mgobj = GameObject.FindWithTag("Player");

                mgobj.GetComponent<MasterGame>().InMenu = false;

                GameObject Canvy;
                Canvy = GameObject.Find("Canvas");
                Canvy.SetActive(false);

                Debug.Log("FadeDone");

                Fade = false;
            }
        }
    }

    public void TheClickPlay()
    {

        Debug.Log("clicked");

        Fade = true;

        //blackScreen = new Color(0, 0, 0, 255);
    }

    public void TheClickOption()
    {


    }

    public void TheClickExit()
    {

        UnityEngine.Application.Quit();
    }
}
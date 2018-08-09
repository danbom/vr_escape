using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imageChange : MonoBehaviour {

    public GameObject player;
    private PlayerControl playerctrl;
    int i=0;

    public static int a=0;
    public Image myImage;
    public Sprite mySecondImage; 
    /*
    public static int b=0;
    public Image myImage2;
    public Sprite mySecondImage2;

    public static int c=0;
    public Image myImage3;
    public Sprite mySecondImage3;

    public static int d=0;
    public Image myImage4;
    public Sprite mySecondImage4;

    public static int e=0;
    public Image myImage5;
    public Sprite mySecondImage5;
    */
    void Start()
    {
        playerctrl = GameObject.Find("CardboardMain").GetComponent<PlayerControl>();
        player = GameObject.Find("CardboardMain");
    }



    void Update()
    {
        playerctrl = GameObject.Find("CardboardMain").GetComponent<PlayerControl>();
        if (playerctrl.MagnetButton.Triggered)
        {
            if (playerctrl.hit_ob == GameObject.Find("puz1"))
            {
                playerctrl.hit_ob.transform.gameObject.SetActive(false);
                myImage.sprite = mySecondImage;
                a++; 
            }
        }
        /*if (playerctrl.MagnetButton.Triggered)
        {
            if (playerctrl.hit_ob == GameObject.Find("puz0"))
            {
                playerctrl.hit_ob.transform.gameObject.SetActive(false);
                myImage2.sprite = mySecondImage2;
                b++; i++;

            }
        }
        if (playerctrl.MagnetButton.Triggered)
        {
            if (playerctrl.hit_ob == GameObject.Find("puz2"))
            {
                playerctrl.hit_ob.transform.gameObject.SetActive(false);
                myImage3.sprite = mySecondImage3;
                c++; i++;

            }
        }
        if (playerctrl.MagnetButton.Triggered)
        {
            if (playerctrl.hit_ob == GameObject.Find("puz3"))
            {
                playerctrl.hit_ob.transform.gameObject.SetActive(false);
                myImage4.sprite = mySecondImage4;
                d++; i++;

            }
        }
        if (playerctrl.MagnetButton.Triggered)
        {
            if (playerctrl.hit_ob == GameObject.Find("puz4"))
            {
                playerctrl.hit_ob.transform.gameObject.SetActive(false);
                myImage5.sprite = mySecondImage5;
                e++; i++;

            }
        }*/





    }
}


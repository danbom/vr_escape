using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imageChange4 : MonoBehaviour
{
    public static int a;
   // public GameObject imageObj;
    public Image myImage;
    public Sprite mySecondImage; //Drag your second sprite here in inspector.
    public GameObject player;
    private PlayerControl playerctrl;

    void Start()
    {
        playerctrl = GameObject.Find("CardboardMain").GetComponent<PlayerControl>();
        player = GameObject.Find("CardboardMain");
      //  imageObj = GameObject.Find("inventory4");
      //  myImage = imageObj.GetComponent<Image>();
    }



    void Update()
    {
        playerctrl = GameObject.Find("CardboardMain").GetComponent<PlayerControl>();
        if (playerctrl.MagnetButton.Triggered)
        {
            
            if (playerctrl.hit_ob == GameObject.Find("puz3"))
            {

                playerctrl.hit_ob.transform.gameObject.SetActive(false);
                myImage.sprite = mySecondImage;
                a++;
            }
        }


    }
}


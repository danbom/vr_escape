using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class openerselect : MonoBehaviour {

    public static int i=0;
    public Image myImage;
    public Sprite mySecondImage;
    public Image noneUsing;

    public void bigImage()
    {
        if (openerImageChange.a == 1){
             myImage.sprite = mySecondImage;
            noneUsing.sprite = mySecondImage;
            i++;
        }
    }
}

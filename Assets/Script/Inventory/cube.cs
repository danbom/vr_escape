using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour,IInventoryItem {

    public string Name
    {
        get
        {
            return "Cube";
        }
    }

    public Sprite _Image = null;
    public Sprite Image 
    {
        get
        {
            return _Image;
        }
    }
   

    public void Onpickup()
    {
        gameObject.SetActive(false);
    }
}

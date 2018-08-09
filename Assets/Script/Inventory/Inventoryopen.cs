using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Inventoryopen : MonoBehaviour {
    public GameObject panel;

    // Use this for initialization
    void Start () {
        panel.gameObject.SetActive(false);
    }

    
    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.C))
        {

            panel.gameObject.SetActive(true);
            


        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            panel.gameObject.SetActive( false);
            
        }
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamCtrl : MonoBehaviour {
    public GameObject player;
    private PlayerControl playerctrl;
    // Use this for initialization

    void Start(){
        playerctrl = GameObject.Find("CardboardMain").GetComponent<PlayerControl>();
        player = GameObject.Find("CardboardMain");
    }
	
	// Update is called once per frame
	void Update () {
        playerctrl = GameObject.Find("CardboardMain").GetComponent<PlayerControl>();
        if (playerctrl.MagnetButton.Triggered)
        {
            if (openerselect.i == 1)
            {
                if (playerctrl.hit_ob.CompareTag("Box"))
                { //ray에 hit한 collider의 Tag가 Box일 경우에

                    playerctrl.hit_ob.transform.gameObject.SetActive(false);
                    player.GetComponent<CapsuleCollider>().center = new Vector3(0, 0, 0);
                    player.GetComponent<CapsuleCollider>().height = 1;

                    player.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                }
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCtrl : MonoBehaviour {
    public GameObject player;
    public float moveSpeed = 10f;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W) == true) { //앞
            player.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) == true) //왼쪽
        {
            player.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) == true) //뒤
        {
            player.transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) == true) //오른쪽
        {
            player.transform.Translate(-Vector3.left * moveSpeed * Time.deltaTime);
        }
    }
}

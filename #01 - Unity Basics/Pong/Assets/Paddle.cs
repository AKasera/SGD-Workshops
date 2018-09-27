using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    public bool isPlayer1 = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (isPlayer1) {
            if (Input.GetKey(KeyCode.W)) {
                GetComponent<Rigidbody2D>().velocity = Vector2.up * 3;
            } else if (Input.GetKey(KeyCode.S)) {
                GetComponent<Rigidbody2D>().velocity = Vector2.down * 3;
            } else {
                GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            }
        } else {
            if (Input.GetKey(KeyCode.UpArrow)) {
                GetComponent<Rigidbody2D>().velocity = Vector2.up * 3;
            } else if (Input.GetKey(KeyCode.DownArrow)) {
                GetComponent<Rigidbody2D>().velocity = Vector2.down * 3;
            } else {
                GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            }
        }
	}
}

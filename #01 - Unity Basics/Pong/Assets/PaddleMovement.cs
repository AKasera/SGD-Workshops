using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour {

    public bool isPLayer1 = true;
    public float speed = 3f;

    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if(isPLayer1)
            rb.velocity = Vector2.up * Input.GetAxis("Vertical") * speed ;
        else
            rb.velocity = Vector2.up * Input.GetAxis("Vertical2") * speed;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMotion : MonoBehaviour {

    public float startSpeed = 5f;
    public float increment = 0.4f;
    private float speed;
    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        Reset();
    }
	
	// Update is called once per frame
	void Update () {
        if (rb.velocity.magnitude != speed) rb.velocity = rb.velocity.normalized* speed;
	}

    public void Reset()
    {
        speed = startSpeed;
        transform.position = Vector3.zero;
        rb.velocity = new Vector2(Random.Range(0, 2) * 2 - 1, Random.Range(-1f, 1)).normalized * speed;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        speed += increment;
    }
}

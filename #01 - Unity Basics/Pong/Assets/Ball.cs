using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public float startSpeed = 5f;
    private float speed;
    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();

        Initialize();
	}

    public void Initialize () {
        speed = startSpeed;
        transform.position = Vector3.zero;
        rb.velocity = new Vector2(Random.Range(0, 2) * 2 - 1, Random.Range(-1f, 1f)).normalized * speed;
    }
	
	// Update is called once per frame
	void Update () {
        if (rb.velocity.magnitude < speed) {
            rb.velocity = rb.velocity.normalized * speed;
        }
	}

    private void OnCollisionEnter2D (Collision2D collision) {
        if (collision.collider.name.Contains("Paddle")) {
            speed += 2f;
        }
    }
}

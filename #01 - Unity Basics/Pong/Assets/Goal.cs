using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

    public string playerName = "Player 1";
    public int score = 0;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Check for collision with the player
    private void OnTriggerEnter2D (Collider2D collision) {
        if (collision.tag == "Player") {
            score++;

            //Display score
            Debug.Log(playerName + ": " + score);

            //Reset the ball
            collision.GetComponent<Ball>().Initialize();
        }
    }
}

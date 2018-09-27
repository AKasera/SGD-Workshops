using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GoalCount : MonoBehaviour {

    public string opponentName = "Player 2";
    public TextMeshProUGUI mytext;
    int score;

	// Use this for initialization
	void Start () {
		mytext.text = "0";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D( Collider2D other)
    {
        if(other.tag == "Player")
        {
            score++;

            print(opponentName + ": " + score);
            other.GetComponent<BallMotion>().Reset();
            mytext.text = "" + score;
        }
    }
}

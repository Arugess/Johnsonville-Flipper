using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This increases the score of the player.//

public class PlayerScore : MonoBehaviour
{
    public static int moreScore = 0;
    Text score;
	// Use this for initialization
	void Start ()
    {
        score = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        score.text = "Player Score: " + moreScore;

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{


	void Start ()
    {
		
	}
	

	void Update ()
    {
		if(PlayerScore.moreScore == -500)
        {
            PlayerScore.moreScore = 0;
            SceneManager.LoadScene("LoseGame");
        }

        if (PlayerScore.moreScore == 1000)
        {
            PlayerScore.moreScore = 0;
            SceneManager.LoadScene("WinGame");
        }
    }
}

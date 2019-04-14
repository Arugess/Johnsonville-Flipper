using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//This allows the player to return to the main menu when they lose.//

public class LoseGameManager : MonoBehaviour
{
    public Button resetButton;

	void Start ()
    {
        Button btn = resetButton.GetComponent<Button>();
        btn.onClick.AddListener(ResetMain);
	}
	

    void ResetMain()
    {
        SceneManager.LoadScene("MainGameScene");
    }
	void Update ()
    {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

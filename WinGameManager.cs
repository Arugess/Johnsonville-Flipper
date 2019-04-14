using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//This allows the player the player to return to the main menu after winning the game.//

public class WinGameManager : MonoBehaviour
{
    public Button restartButton;

    void Start()
    {
        Button btn = restartButton.GetComponent<Button>();
        btn.onClick.AddListener(RestartMain);
    }


    void RestartMain()
    {
        SceneManager.LoadScene("TitleScene");
    }
    void Update()
    {

    }
}

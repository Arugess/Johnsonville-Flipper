using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//This allows the player to enter the game from the main menu.//

public class TitleManager : MonoBehaviour
{
    public Button startButton;

    void Start()
    {
        Button btn = startButton.GetComponent<Button>();
        btn.onClick.AddListener(StartMain);
    }


    void StartMain()
    {
        SceneManager.LoadScene("MainGameScene");
    }
    void Update()
    {

    }
}

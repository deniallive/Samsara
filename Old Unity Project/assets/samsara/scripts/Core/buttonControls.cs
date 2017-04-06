using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonControls : MonoBehaviour {

    public void startGame(string startGame)
    {
        SceneManager.LoadScene(startGame);
    }

    public void exitGame()
    {
        Application.Quit();
    }
}

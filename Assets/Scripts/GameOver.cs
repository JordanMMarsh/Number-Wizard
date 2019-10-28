using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	public void MainMenu()
    {
        SceneManager.LoadScene("Start Menu");
    }

    public void NewGame()
    {
        SceneManager.LoadScene("Main Game");
    }
}

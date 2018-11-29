using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour {
    public int Lives = 10;

	public void NewGame()
    {
        SceneManager.LoadScene("Level1");
        PlayerPrefs.SetInt("Lives", Lives);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}

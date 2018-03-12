using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtonManager : MonoBehaviour {

	
    public void RestartBtn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ExitBtn()
    {
        Application.Quit();
    }

    public void MainMenuBtn()
    {
        int nextBuildIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene("MainMenu");
    }

    public void StartBtn()
    {
        SceneManager.LoadScene("GameScene");
    }

}

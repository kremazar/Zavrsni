using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void Score()
    {
        SceneManager.LoadScene("Scores");
    }
    public void Exit()
    {
        Application.Quit();
    }

}

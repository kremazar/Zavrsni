using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public static int lifes = 3;
    Text score;
    void Start()
    {
        score = GetComponent<Text>();
    }


    void Update()
    {
        score.text = "Life: " + lifes;

        if (lifes == 0)
        {
            SceneManager.LoadScene("Menu");
            lifes = 3;
            Score.scoreValue = 0;
        }
    }
}

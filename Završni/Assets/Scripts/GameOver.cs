using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
public class GameOver : MonoBehaviour
{
    public static int lifes = 3;
    Text life;
    public Text bulletDmg;
     void Start()
    {
        life = GetComponent<Text>();
    }


    void Update()
    {
        life.text = "Life: " + lifes;
        bulletDmg.text = "Bullet damage: " + Bullet.damage;


        if (lifes == 0)
        {
            Save();
            lifes = 3;
            Score.scoreValue = 0;
            SceneManager.LoadScene("Credits");
        }
    }
    public void Save()
    {
        string path = Application.dataPath + "/score.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "");
        }
        string content = "Score :" + Score.scoreValue.ToString() + "\n";
        File.AppendAllText(path, content);
        Debug.Log(Application.dataPath);
    }
    
}

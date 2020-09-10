using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;


public class SaveScore : MonoBehaviour
{
    string[] data;
    string path;
    public Text score;
    void Start()
    {
        path = Application.dataPath + "/score.txt";
        Load();
    }
    public  void Load()
    {
        data = File.ReadAllLines(path);
        foreach (string line in data)
        {
            score.text += line +"\n";
        }
    }
}

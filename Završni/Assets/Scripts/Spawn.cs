using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject [] enemy;
    public GameObject [] helpItems;
    private int random;
    public Vector2 whereToSpawn1;
    public Vector2 whereToSpawn2;
    public Vector2 whereToSpawn3;
    public float spawnRate = 10f;
    public float spawnHelp = 10f;
    float nextSpawn = 0.0f;
    float nextHelp = 0.0f;


    void Update()
    {
       
        random = Random.Range(0, 3);
        Vector2 whereToSpawn1 = new Vector2(Random.Range(-46.3f, 46.2f), 35f);
        Vector2 whereToSpawn2 = new Vector2(Random.Range(-46.3f, 46.2f), -32f);
        Vector2 whereToSpawn3 = new Vector2(-54f, Random.Range(34f, -27.2f));
        Vector2 whereToSpawn4 = new Vector2(Random.Range(-42.7f, 40.7f), Random.Range(25.9f, -20.7f));
        if (Time.time > nextSpawn)
        {
            
            nextSpawn = Time.time + spawnRate;
            spawnRate -= 0.5f;
            Instantiate(enemy[random], whereToSpawn1, Quaternion.identity);
            Instantiate(enemy[random], whereToSpawn2, Quaternion.identity);
            Instantiate(enemy[random], whereToSpawn3, Quaternion.identity);
            if(spawnRate == 2)
            {
                spawnRate += 0.5f;

            }     
        }
        if (Time.time > nextHelp)
        {
            nextHelp = Time.time + spawnHelp;
            Instantiate(helpItems[random], whereToSpawn4, Quaternion.identity);
        }
    }
}

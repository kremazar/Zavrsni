using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemy;
    public GameObject [] helpItems;
    private int random;
    public Vector2 whereToSpawn;
    public Vector2 whereToSpawn2;
    public Vector2 whereToSpawn3;
    public float spawnRate = 10f;
    float nextSpawn = 0.0f;



    void Update()
    {
        Vector2 whereToSpawn = new Vector2(-50, -24);
        Vector2 whereToSpawn2 = new Vector2(51, 32);
        random = Random.Range(0, 3);
        Vector2 whereToSpawn3 = new Vector2(Random.Range(-42.7f, 40.7f), Random.Range(25.9f, -20.7f));
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            spawnRate -= 0.1f;
           
            if (spawnRate <= 5f)
            {
                spawnRate += 0.1f;
                
            }
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
            Instantiate(enemy, whereToSpawn2, Quaternion.identity);
            Instantiate(helpItems[random], whereToSpawn3, Quaternion.identity);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemy;
    public GameObject [] helpItems;
    public Vector2 whereToSpawn;
    public Vector2 whereToSpawn2;
    public Vector2 whereToSpawn3;
    public float spawnRate = 5f;
    float nextSpawn = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 3; i++)
        {
            if (helpItems[i] == null)
            {
                helpItems[i] = GameObject.FindWithTag("Help");
            }
        }
        
        Vector2 whereToSpawn3 = new Vector2(Random.Range(50f, -24f), Random.Range(50f, -24f));
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
            Instantiate(enemy, whereToSpawn2, Quaternion.identity);
            Instantiate(helpItems[0], whereToSpawn3, Quaternion.identity);
        }
    }
}

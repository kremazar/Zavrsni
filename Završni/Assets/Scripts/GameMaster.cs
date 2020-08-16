using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public static GameMaster gm;
    public Transform playerPrefab;
    public Transform spawnPoint;
  

    void Start()
    {
        if (gm == null)
        {
            gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
            
        }
    }
   void Update()
    {
        if(playerPrefab == null)
        {
            playerPrefab = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }
   
   
    public void RespawnPlayer()
    {
        Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);
        GameOver.lifes -= 1;
      
    }
    public static void KillPlayer (Player player)
    {
        Destroy(player.gameObject);
        gm.RespawnPlayer();
    }
    public static void KillEnemy(Enemy enemy)
    {
        Destroy(enemy.gameObject);
        Score.scoreValue += 10;
    }
}

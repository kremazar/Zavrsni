using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameMaster : MonoBehaviour
{
    public static GameMaster gm;
    public Transform playerPrefab;
    public Transform spawnPoint;

    public int count = 3;
    public Text countText;
    public GameObject canvas;


    void Start()
    {
        StartCoroutine(CountDownStart());
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

     IEnumerator CountDownStart()
    {
        Time.timeScale = 0f;
        while (count > 0)
        {
            
            countText.text = count.ToString();
            yield return new WaitForSecondsRealtime(1f);
            count--;
            

        }
        countText.text = "Go";

        yield return new WaitForSecondsRealtime(1f);

        canvas.SetActive(false);
        Time.timeScale = 1f;

    }

    public void RespawnPlayer()
    {
        Application.LoadLevel(Application.loadedLevel);
        Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);
        GameOver.lifes -= 1;
        Bullet.damage = 10;
      
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

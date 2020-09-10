using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [System.Serializable]
   public class PlayerStats
    {
        public int maxHealth = 100;

        private int _curHealth;
        public int curHealth
        {
            get { return _curHealth; }
            set { _curHealth = Mathf.Clamp(value, 0, maxHealth); }
        }
        public void Init()
        {
            curHealth = maxHealth;
        }
    }
    public PlayerStats stats = new PlayerStats();

    [SerializeField]
    private Status statusIndicator;

    void Start()
    {
        stats.Init();
        if (statusIndicator == null)
        {
            Debug.LogError("NO status indicator on player");
        }
        else
        {
            statusIndicator.SetHealth(stats.curHealth, stats.maxHealth);
        }
    }
    void Update()
    {
        statusIndicator.SetHealth(stats.curHealth, stats.maxHealth);
    }
    
    public void DamagePlayer (int damage)
    {
        stats.curHealth -= damage;
        if (stats.curHealth<= 0)
        {
            GameMaster.KillPlayer(this);
        }
        statusIndicator.SetHealth(stats.curHealth, stats.maxHealth);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag != "Player")
        {
            if (collision.gameObject.name == "health(Clone)")
            {
                stats.curHealth = stats.maxHealth;
                Debug.Log(stats.curHealth);
                Destroy(collision.gameObject);
            }
            if (collision.gameObject.name == "ammo(Clone)")
            {
                Bullet.damage += 10;
                Debug.Log(Bullet.damage);
                Destroy(collision.gameObject);
            }
            if (collision.gameObject.name == "life(Clone)")
            {
                GameOver.lifes += 1;
                Destroy(collision.gameObject);
            }
        }
       

    }
}

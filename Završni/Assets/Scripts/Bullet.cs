using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public static int damage = 10;
    GameObject target;
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        target = GameObject.FindWithTag("Player");
        if (collision.gameObject.tag != target.tag)
        {
            Enemy enemy = collision.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.DamageEnemy(damage);
            }
            Destroy(gameObject);
        }
        
    }
}

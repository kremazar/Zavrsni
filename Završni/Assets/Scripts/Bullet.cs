using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;
    public int damage = 10;
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        Enemy enemy = collision.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.DamageEnemy(damage);
        }
        Destroy(gameObject);
        //GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        //Destroy(effect, 5f);
        
        Destroy(gameObject);
    }
}

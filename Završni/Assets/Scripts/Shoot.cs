using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Shoot : MonoBehaviour
{
    public int Damage = 10;
    public Transform firePoint;
    public GameObject bulletPrefab;
    public static float bulletForce = 100f;
    public AudioSource audioData;

void Start()
    {
        audioData = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shooot();
  
        }
    }
    void Shooot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        audioData.Play();
        Destroy(bullet, 1);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drugiWeapon : MonoBehaviour
{
    public GameObject meta;
    public GameObject player;
    public GameObject metak;
    private Vector3 target;
    public float bulletSpeed = 60.0f;
    public LayerMask whatToHit;
    public int Damage = 10;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        target = transform.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition + Vector3.forward * 10);
        meta.transform.position = new Vector2(target.x,target.y);
        Vector3 difference = target - player.transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        //player.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);

        if (Input.GetMouseButtonDown(0))
        {
            float distance = difference.magnitude;
            Vector2 direction = difference / distance;
            direction.Normalize();
            fireBullet(direction, rotationZ);
        }
    }
    void fireBullet(Vector2 direction, float rotationZ)
    {
        GameObject pucanj = Instantiate(metak) as GameObject;
        pucanj.transform.position = player.transform.position;
        pucanj.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        pucanj.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
        RaycastHit2D hit = Physics2D.Raycast(target, Vector2.zero, whatToHit);
       
        Enemy enemy = hit.collider.GetComponent<Enemy>();
        if(enemy != null)
        {
            enemy.DamageEnemy(Damage);
            Debug.Log("We hit " + hit.collider.name + " and did " + Damage + " damage. ");
        }
        
        Destroy(pucanj, 1);
    }
}

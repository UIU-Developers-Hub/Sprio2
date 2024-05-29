using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform point1,point2;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot1()
    {
        GameObject bullet = Instantiate(bulletPrefab, point1.position, point1.rotation);
        Rigidbody2D rb1 = bullet.GetComponent<Rigidbody2D>();
        rb1.AddForce(point1.up * bulletForce, ForceMode2D.Impulse);
    }

    public void Shoot2()
    {
        GameObject bullet = Instantiate(bulletPrefab, point2.position, point2.rotation);
        Rigidbody2D rb2 = bullet.GetComponent<Rigidbody2D>();
        rb2.AddForce(point2.up * bulletForce, ForceMode2D.Impulse);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private Rigidbody2D rb;
    private Transform dir;
    float dx,dy;
    public float speed = 10f;
    public float dirSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        dir = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        dx = Input.acceleration.x * speed;
        dy = Input.acceleration.y * dirSpeed;
        
        rb.AddTorque(-dx, ForceMode2D.Force);
        //transform.Rotate(Vector3.forward, -dx);
        rb.AddForce(dir.up * dy, ForceMode2D.Force);
    }
}

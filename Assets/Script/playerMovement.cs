using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    float dx,dy;
    float speed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dx = Input.acceleration.x * speed;
        dy = Input.acceleration.y * speed;

    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dx, dy);
    }
}

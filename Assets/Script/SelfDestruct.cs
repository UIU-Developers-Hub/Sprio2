using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    public float countDown = 1f;
    private float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = countDown;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            if(currentTime <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}

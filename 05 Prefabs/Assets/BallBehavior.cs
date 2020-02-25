using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    Vector2 position;
    Vector2 velocity;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        //position = new Vector2(Random.Range(-5f, 5f), 4);
        velocity = new Vector2(Random.Range(-2f, 2f), 1);

        //transform.position = position;
        rb.velocity = velocity;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

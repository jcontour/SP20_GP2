using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunWithPhysics : MonoBehaviour
{

    Rigidbody2D rb;
    public float forceAmount;
    float horizontal;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            //Debug.Log("I pressed space");
            rb.AddForce(Vector2.up*forceAmount, ForceMode2D.Impulse);
        }

        horizontal = Input.GetAxis("Horizontal");

        // moving side to side by setting velocity = a little more snappy
        Vector2 vel = rb.velocity;
        vel = new Vector2(horizontal * speed, vel.y);
        rb.velocity = vel;

        // moving side to side by adding a force = kind of floaty movement
        //rb.AddForce(new Vector2(horizontal*speed, 0));

    }
}

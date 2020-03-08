using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGravity : MonoBehaviour
{

    public GameObject ball;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = ball.GetComponent<Rigidbody2D>();
    }

    public void SwitchGravity()
    {
        float currentgrav = rb.gravityScale;
        rb.gravityScale = currentgrav * -1;
    }
}

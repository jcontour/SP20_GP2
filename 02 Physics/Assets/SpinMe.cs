using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinMe : MonoBehaviour
{
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S)) {
            rb.AddTorque(10);
        }

        if (Input.GetKeyUp(KeyCode.S)) {
            rb.angularVelocity = 0;
        }
    }
}

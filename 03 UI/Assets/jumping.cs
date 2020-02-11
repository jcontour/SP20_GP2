using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumping : MonoBehaviour
{

    int jumpsAllowed;
    int numJumps;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        numJumps = 0;
        jumpsAllowed = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            
            if (numJumps < jumpsAllowed) {
                rb.AddForce(transform.up*5, ForceMode2D.Impulse);
                numJumps++;
            }   
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground") {
            numJumps = 0;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotPotato : MonoBehaviour
{

    Rigidbody2D rb;
    public bool holdingPotato;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        holdingPotato = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (holdingPotato)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("HOT POTATO");
                rb.AddForce(transform.up * 5, ForceMode2D.Impulse);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        holdingPotato = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        holdingPotato = false;
    }

}

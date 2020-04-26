using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharControl : MonoBehaviour
{

    public float speed;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    float horizontal, vertical;


    SpriteRenderer sr;
    public Sprite front, left, right, back;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (GetComponent<ActionManager>().showingHorseDialogue == false)
        {
            horizontal = Input.GetAxisRaw("Horizontal");
            vertical = Input.GetAxisRaw("Vertical");
            Vector2 moveInput = new Vector2(horizontal, vertical);
            moveVelocity = moveInput.normalized * speed;

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                sr.sprite = left;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                sr.sprite = right;
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                sr.sprite = back;
            }
            else
            {
                sr.sprite = front;
            }
        } else
        {
            moveVelocity = new Vector2(0, 0);
        }


    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
        
    }

}

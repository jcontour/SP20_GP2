using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTime : MonoBehaviour
{

    SpriteRenderer sr;
    AudioSource coinNoise;
    
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        coinNoise = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // we have access to the object we collided with
        //Debug.Log(collision.gameObject.name);
        //Debug.Log(collision.gameObject.tag);

        //if (collision.gameObject.name == "Frank") // << checking the name
        if (collision.gameObject.tag == "SpecialSquare") // << checking the tag
        {
            sr.color = Color.blue;

            // getting components on the collision object to do stuff with them
            SpriteRenderer FranksSR = collision.gameObject.GetComponent<SpriteRenderer>();
            FranksSR.color = Color.yellow;
        }
        else if (collision.gameObject.tag == "Collectable") {
            Destroy(collision.gameObject);
            coinNoise.Play();
        }

        else
        {
            sr.color = Color.red;
        }



        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        sr.color = Color.white;
    }
}

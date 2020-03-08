using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetInfoAboutCollisionObject : MonoBehaviour
{

    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // saving current color as variable and assigning to our color.
        Color platformColor = collision.gameObject.GetComponent<SpriteRenderer>().color;
        sr.color = platformColor;

        // can also change the color on collision
        // collision.gameObject.GetComponent<SpriteRenderer>().color = Color.red;


    }

}

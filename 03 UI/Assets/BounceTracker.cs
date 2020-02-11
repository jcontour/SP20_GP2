using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BounceTracker : MonoBehaviour
{
    int numBounces;

    public Text bounceText;
    public Slider bounceSlider;

    SpriteRenderer sr;
    

    // Start is called before the first frame update
    void Start()
    {
        bounceText.text = "It's bouncing time :D";
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            numBounces++;

            bounceSlider.value = numBounces;
            bounceText.text = "Bounce: " + numBounces;

            if (numBounces > 5) {
                bounceText.text = "wow";
                sr.color = Color.red;
            }
            //Debug.Log(numBounces);
        }
    }

    public void ResetBounces() {
        numBounces = 0;
        sr.color = Color.white;
       
        bounceSlider.value = numBounces;
        bounceText.text = "Bounce: " + numBounces;
    }


}

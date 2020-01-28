using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunWithMath : MonoBehaviour
{

    Vector2 pos;
    public float speed;

    Vector2 circlemove;

    Vector3 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // overwriting the current position with entirely new value
        //pos = transform.position;
        //pos.x += speed * Time.deltaTime;
        //transform.position = pos;
        // how to print to console
        //Debug.Log(pos);

        // add a vector to the current position
        // these are the same
        //transform.Translate(new Vector2(speed, 0) * Time.deltaTime);
        //transform.Translate(transform.right * speed * Time.deltaTime);
        //transform.Rotate(Vector3.right*5);

        // move across the screen and up and down using sin/cos
        //Mathf.Sin(Time.time * speed_of_movement) * distance_of_movement;
        //circlemove.x += speed * Time.deltaTime;
        //circlemove.y = Mathf.Sin(Time.time*5);
        //transform.position = circlemove;

        // follow the mouse!
        mousePos = Input.mousePosition;
        Vector3 mouseOnScreen = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 10));

        transform.position = Vector2.MoveTowards(transform.position, mouseOnScreen, speed * Time.deltaTime);

        //Debug.Log(mouseOnScreen);
    }
}

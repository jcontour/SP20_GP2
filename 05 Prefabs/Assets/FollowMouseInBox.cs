using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouseInBox : MonoBehaviour
{
    Vector2 boxDimensions = new Vector2(3, 3);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 mouseOnScreen = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 10));

        transform.position = mouseOnScreen;
        if (transform.position.x >= boxDimensions.x)
        {
            transform.position = new Vector2(boxDimensions.x, transform.position.y);
        }
        if (transform.position.x <= -boxDimensions.x)
        {
            transform.position = new Vector2(-boxDimensions.x, transform.position.y);
        }
        if (transform.position.y >= boxDimensions.y)
        {
            transform.position = new Vector2(transform.position.x, boxDimensions.y);
        }
        if (transform.position.y <= -boxDimensions.y)
        {
            transform.position = new Vector2(transform.position.x, -boxDimensions.y);
        }
    }
}

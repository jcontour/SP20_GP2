using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackAndForth : MonoBehaviour
{
    bool isMovingRight;
    float xLoc;
    Vector2 pos;

    // Start is called before the first frame update
    void Start()
    {
        xLoc = -3f;
        isMovingRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isMovingRight) {
            xLoc += Time.deltaTime;

            if (xLoc > 3f) {
                isMovingRight = false;
            }

        } else
        {
            xLoc -= Time.deltaTime;

            if (xLoc < -3f)
            {
                isMovingRight = true;
            }
        }


        pos.x = xLoc;
        transform.position = pos;

    }
}

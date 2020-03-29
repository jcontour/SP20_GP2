using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scan : MonoBehaviour
{

    bool leftToRight;
    Quaternion angle;
    float zAngle;
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        leftToRight = true;
        zAngle = 0;
        speed = 100;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = angle;

        if (leftToRight)
        {
            zAngle -= Time.deltaTime * speed;
            angle = Quaternion.Euler(0, 0, zAngle);

            if (zAngle <= -45)
            {
                leftToRight = !leftToRight;
            }
        } else
        {
            zAngle += Time.deltaTime * speed;
            angle = Quaternion.Euler(0, 0, zAngle);

            if (zAngle >= 45)
            {
                leftToRight = !leftToRight;
            }
        }
    }
}

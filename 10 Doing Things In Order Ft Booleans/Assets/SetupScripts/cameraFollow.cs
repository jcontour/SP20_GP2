using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{

    public GameObject c;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        c.transform.position = new Vector3 (transform.position.x, transform.position.y, -10);
        if (c.transform.position.x < -2.23f)
        {
            c.transform.position = new Vector3(-2.23f, c.transform.position.y, -10);
        }
        if (c.transform.position.x > 2.19f)
        {
            c.transform.position = new Vector3(2.19f, c.transform.position.y, -10);
        }
        if (c.transform.position.y < -6.8f)
        {
            c.transform.position = new Vector3(c.transform.position.x, -6.8f, -10);
        }
        if (c.transform.position.y > 5.41f)
        {
            c.transform.position = new Vector3(c.transform.position.x, 5.41f, -10);
        }
    }
}

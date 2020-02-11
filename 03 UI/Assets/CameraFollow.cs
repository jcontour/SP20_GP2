using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject mycamera;
    float maxY;

    // Start is called before the first frame update
    void Start()
    {
        maxY = 3.0f;
    }

    // Update is called once per frame
    void Update()
    {
        mycamera.transform.position = new Vector3(transform.position.x, transform.position.y, -10);
        // limiting follow movement past certain positions;
        if (mycamera.transform.position.y > maxY) {
            mycamera.transform.position = new Vector3(transform.position.x, maxY, -10);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spiral : MonoBehaviour
{

    float radius;
    Vector2 pos;

    // Start is called before the first frame update
    void Start()
    {
        radius = 0;
    }

    // Update is called once per frame
    void Update()
    {
        pos.x = Mathf.Sin(Time.time*5)*radius;
        pos.y = Mathf.Cos(Time.time*5)*radius;

        radius += Time.deltaTime;

        transform.position = pos;
    }
}

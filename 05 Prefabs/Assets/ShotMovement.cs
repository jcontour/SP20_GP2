using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotMovement : MonoBehaviour
{
    float timer;

    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * 5);

        timer += Time.deltaTime;
        if (timer > 2)
        {
            Destroy(this.gameObject);
        }

    }
}

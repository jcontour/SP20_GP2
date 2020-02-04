using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayOnScreen : MonoBehaviour
{

    Vector2 cameraDim;
    Vector2 worldDim;

    // Start is called before the first frame update
    void Start()
    {
        cameraDim = new Vector2(Screen.width, Screen.height);
        worldDim = Camera.main.ScreenToWorldPoint(new Vector2(cameraDim.x, cameraDim.y));       
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= worldDim.x + 0.2f) {
            transform.position = new Vector2(worldDim.x * -1, transform.position.y);
        }

        if (transform.position.x <= worldDim.x * -1 - 0.2f) {
            transform.position = new Vector2(worldDim.x, transform.position.y);
        }
    }
}

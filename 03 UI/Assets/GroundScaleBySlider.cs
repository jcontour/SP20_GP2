using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GroundScaleBySlider : MonoBehaviour
{
    public GameObject ground;
    Slider s;
    Vector3 groundSize;

    private void Start()
    {
        s = GetComponent<Slider>();
        groundSize = ground.transform.localScale;
    }

    public void ScaleGround() {
        Debug.Log(s.value);
        // method 1: create new vector value and set equal
        ground.transform.localScale = new Vector3(s.value, ground.transform.localScale.y, 1);

        // method 2: modify existing vector3 variable and set equal
        //groundSize.x = s.value;
        //ground.transform.localScale = groundSize;
    }
}

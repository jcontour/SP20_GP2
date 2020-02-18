using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedClicker : MonoBehaviour
{

    public Slider s;
    float counter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if (Input.GetButtonDown("Fire1"))
        {
            counter = 0;
        }
        s.value = 1 - counter;

    }
}

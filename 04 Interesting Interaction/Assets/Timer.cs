using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Slider s;
    public Text t;

    public HotPotato hp;
    float timerVal;

    // Start is called before the first frame update
    void Start()
    {   
        t.enabled = false;
    }

    // Update is called once per frame
  void Update()
    {
        if (hp.holdingPotato)
        {
            timerVal += Time.deltaTime;
        } else
        {
            timerVal = 0;
        }

        if (timerVal >= 5)
        {
            hp.enabled = false;
            t.enabled = true;
        }

        s.value = timerVal;
    }
}

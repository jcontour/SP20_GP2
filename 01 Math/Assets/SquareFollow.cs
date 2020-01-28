using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareFollow : MonoBehaviour
{

    public GameObject mommySquare;
    Vector2 mommypos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mommypos = mommySquare.transform.position;
        //transform.position = mommypos;
        transform.position = new Vector2(mommypos.x, Mathf.Sin(Time.time) + mommypos.y);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveButton : MonoBehaviour
{

    float randomNum;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1) {
            ResetRandomNum();
            timer = 0;
        }
        transform.position = new Vector2(transform.position.x, Mathf.Sin(Time.time) * randomNum);
    }

    void ResetRandomNum()
    {
        randomNum = Random.Range(2, 5);
    }
}

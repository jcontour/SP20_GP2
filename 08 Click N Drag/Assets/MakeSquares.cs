using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeSquares : MonoBehaviour
{
    float timer;
    public GameObject squarePrefab;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0)
        {
            GameObject s = Instantiate(squarePrefab);
            s.transform.position = new Vector2(Random.Range(-6, 6), 6);
            timer = 0.5f;
        }

        timer -= Time.deltaTime;
    }
}

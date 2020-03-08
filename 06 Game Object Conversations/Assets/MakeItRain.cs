using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeItRain : MonoBehaviour
{

    public GameObject ball_prefab;
    float rainTimer;
    bool UpOrDown;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rainTimer += Time.deltaTime;
        if (rainTimer > 0.2f) {

            if (UpOrDown)
            {
                // instantiate ball at random x position at top of screen
                Instantiate(ball_prefab, new Vector2(Random.Range(-6.5f, 6.5f), 5), Quaternion.identity);
            } else
            {
                GameObject bottomBall = Instantiate(ball_prefab, new Vector2(Random.Range(-6.5f, 6.5f), -4.5f), Quaternion.identity);
                bottomBall.GetComponent<Rigidbody2D>().gravityScale = -1;
            }

            UpOrDown = !UpOrDown;
            rainTimer = 0;

        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            // turn balls blue
            GameObject[] balls;
            balls = GameObject.FindGameObjectsWithTag("ball");

            foreach (GameObject b in balls)
            {
                b.GetComponent<SpriteRenderer>().color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            }

        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            // turn random ball into a giant
            GameObject[] balls;
            balls = GameObject.FindGameObjectsWithTag("ball");

            float randomSize = Random.Range(1, 5);
            balls[Random.Range(0, balls.Length)].transform.localScale = new Vector3(randomSize, randomSize, 0);

        }

    }
}

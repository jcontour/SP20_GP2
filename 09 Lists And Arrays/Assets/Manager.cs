using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    //public static Manager manager;

    public GameObject ball_prefab;
    float timer;

    List<GameObject> balls = new List<GameObject>();

    public Transform bucketspawnloc;
    public Transform fireloc;

    int score;
    public int minScore;
    public Text scoretext;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        score = 0;
        scoretext.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        // collect the balls
        if (score < minScore)
        {
            timer += Time.deltaTime;

            if (timer > 0.25f)
            {
                timer = 0;
                Instantiate(ball_prefab, new Vector2(Random.Range(-3f, 7f), 5), Quaternion.identity);
            }
        } else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                foreach (GameObject b in balls)
                {
                    b.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
                }
            }
            if (Input.GetMouseButtonDown(0)){
                int randomBall = Random.Range(0, balls.Count);
                ShootBall(randomBall);
            }
        }

        Vector3 followPos = mousePos();
        transform.position = new Vector2(followPos.x, transform.position.y);
        if (transform.position.x < -1.92f)
        {
            transform.position = new Vector2(-1.92f, transform.position.y);
        } else if (transform.position.x >= 5.8f)
        {
            transform.position = new Vector2(5.8f, transform.position.y);
        }
    }

    void ShootBall(int b)
    {
        balls[b].transform.position = fireloc.position;
        balls[b].GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-1, 1), 10);
        balls.Remove(balls[b]);
    }

    public void CollectBalls(GameObject ball)
    {
        balls.Add(ball);
        Debug.Log(balls.Count);
        ball.transform.position = bucketspawnloc.position + new Vector3(Random.Range(-0.5f,0.5f),0,0);
        score++;
        scoretext.text = score.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        CollectBalls(collision.gameObject);
    }

    Vector3 mousePos()
    {
        return Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
    }
}

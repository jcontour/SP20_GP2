using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePlatforms : MonoBehaviour
{

    public GameObject platform_prefab;
    float rateOfPlatformCreation;
    float timer;
    float platformSpeed;

    float maxWidth;

    float difficultyTimer;

    // Start is called before the first frame update
    void Start()
    {
        rateOfPlatformCreation = 2f;
        maxWidth = 10f;
        platformSpeed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= rateOfPlatformCreation)
        {
            GameObject p = Instantiate(platform_prefab);
            p.transform.position = new Vector2(Random.Range(-6f, 6f), -5f);
            p.transform.localScale = new Vector2(Random.Range(3, maxWidth), 0.5f);
            p.GetComponent<PlatformMovement>().speed = platformSpeed;

            timer = 0;
        }

        difficultyTimer += Time.deltaTime;
        if (difficultyTimer >= 3)
        {
            rateOfPlatformCreation -= 0.25f;
            if (rateOfPlatformCreation <= 0.25f)
            {
                rateOfPlatformCreation = 0.25f;
            }

            maxWidth -= 1;
            if (maxWidth < 4)
            {
                maxWidth = 4;
            }

            platformSpeed += 0.5f;
            if (platformSpeed > 6)
            {
                platformSpeed = 6;
            }

            difficultyTimer = 0;
        }
    }
}

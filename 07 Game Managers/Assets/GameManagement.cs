using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{

    public static GameManagement manager;
    public int sceneNum;
    public int score;

    void Awake()
    {
        if (manager == null)
        {
            manager = this;
            DontDestroyOnLoad(this);
        } else if(manager != this)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        sceneNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    NextScene();
        //}
    }

    public void NextScene()
    {
        sceneNum++;
        if (sceneNum >= 4)
        {
            sceneNum = 0;
            score = 0;
        }
        SceneManager.LoadScene(sceneNum);
    }

    public void ChangeScore(int changeAmount)
    {

        score += changeAmount;
        Debug.Log(score);

        if (sceneNum == 1 && score >= 10)
        {
            NextScene();
        } else if (sceneNum == 2 && score > 20)
        {
            NextScene();
        }
    }

    
}

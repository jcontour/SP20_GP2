using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreChanger : MonoBehaviour
{

    public int scoreChangeAmount;

    private void Start()
    {
        Text scoreText = GameObject.FindGameObjectWithTag("score").GetComponent<Text>();
        scoreText.text = GameManagement.manager.score.ToString();
    }

    private void OnMouseDown()
    {
        GameManagement.manager.ChangeScore(scoreChangeAmount);
        Text scoreText = GameObject.FindGameObjectWithTag("score").GetComponent<Text>();
        scoreText.text = GameManagement.manager.score.ToString();
    }
}

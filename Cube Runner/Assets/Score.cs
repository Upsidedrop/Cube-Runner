using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    int score = 0;

    
    public static string ScoreString;
    public TMP_Text ScoreText;


    private void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.buildIndex == 2)
        {
            InvokeRepeating(nameof(ChangeScore), 1, 1);

    }     } 
    void ChangeScore()
    {
        score++;
    }
    private void Update()
    {
        ScoreText.text = "Score:" + score;
        ScoreString = ScoreText.text;
    }
}


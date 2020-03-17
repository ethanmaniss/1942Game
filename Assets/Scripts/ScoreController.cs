using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// https://answers.unity.com/questions/1002819/how-do-i-save-highscore.html

public class ScoreController : MonoBehaviour
{
    public int score = 0;

    public int highScore = 0;

    void Start()
    {

        score = 0;

        highScore = PlayerPrefs.GetInt("Highscore: ", highScore);
    }

    void Update()
    {
        if(score > highScore)
        {
            highScore = score;

            PlayerPrefs.SetInt("Highscore: ", highScore);
        }

    }

    void OnDestroy()
    {
        PlayerPrefs.SetInt("Highscore: ", highScore);
        PlayerPrefs.Save();
    }


    public void UpdateScore()
    {
        GetComponent<Text>().text = "Score: " + score;
        GetComponent<Text>().text = "Highscore: " + highScore;
    }
    
}

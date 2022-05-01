using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance;

    public TMP_Text scoreText;
    public TMP_Text highScoreText;

    public GameObject scorePopup;

    int score = 0;
    int highScore = 0;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {

        highScore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = score.ToString();
        highScoreText.text = highScore.ToString();
    }

    public void AddPoint(int points)
    {
        score += points;
        scoreText.text = score.ToString();
        

        if(highScore < score){
            PlayerPrefs.SetInt("highscore", score);
        }

        scorePopup.SetActive(true);
        StartCoroutine(wait());
    }

    private IEnumerator wait(){

        yield return new WaitForSeconds(1);
        scorePopup.SetActive(false);
    }

    void Update()
    {
        
    }
}

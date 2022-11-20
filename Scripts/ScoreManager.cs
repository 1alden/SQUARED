using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int score, highScore;

    public Text scoreText, highScoreText, gameOverScoreText;

    Color[] colors = new Color[2];
    AudioSource source;
    public AudioClip button;

    private changeColorWithtag color;
    private flyingenemy time;

    public bool added = false;
    public bool added1 = false;
    public bool added2 = false;
    public bool added3 = false;
    public bool added4 = false;
    public bool added5 = false;
    public bool added6 = false;
    public bool added7 = false;
    public bool added8 = false;
    public bool added9 = false;
    public bool added10 = false;

    private void Awake()
    {
        instance = this;

        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetInt("HighScore");
            highScoreText.text = highScore.ToString();
        }

    }

    void Start()
    {
        time = FindObjectOfType<flyingenemy>();
        color = FindObjectOfType<changeColorWithtag>();
        source = GetComponent<AudioSource>();
    }


    void Update()
    {
        if(score == 5 && added == false)
        {
            time.decreaseTimed();
            added = true;
        }
        if (score == 10 && added1 == false)
        {
            time.decreaseTimed();
            added1 = true;
        }
        if (score == 15 && added2 == false)
        {
            time.decreaseTimed();
            added2 = true;
        }
        if (score == 20 && added3 == false)
        {
            time.decreaseTimed();
            added3 = true;
        }

        if (score == 25 && added4 == false)
        {
            time.decreaseTimed();
            added4 = true;
        }
        if (score == 30 && added5 == false)
        {
            time.decreaseTimed();
            added5 = true;
        }
        if (score == 35 && added6 == false)
        {
            time.decreaseTimed();
            added6 = true;
        }
        if (score == 40 && added7 == false)
        {
            time.decreaseTimed();
            added7 = true;
        }
        if (score == 45 && added8 == false)
        {
            time.decreaseTimed();
            added8 = true;
        }
        if (score == 50 && added9 == false)
        {
            time.decreaseTimed();
            added9 = true;
        }

        if (score == 0)
        {
            color.StartingColor();
        }
        if (score >= 1 && score <= 3)
        {
            color.ChangeColorAtFifteenPoints();
        }
        if (score >= 4 && score <= 8)
        {
            color.ChangeColorAtFivePoints();
        }
        if (score >= 9 && score <= 15)
        {
            color.ChangeColorAtTenPoints();
        }
        if (score >= 16 && score <= 24)
        {
            color.ChangeColorAtThirtyPoints();
        }
        if (score >= 25 && score <= 35)
        {
            color.ChangeColorAtTwentyPoints();
        }
        if (score >= 36 && score <= 48)
        {
            color.ChangeColorAtFourtyPoints();
        }
        if (score >= 49 && score <= 63)
        {
            color.ChangeColorAtFourtyFivePoints();
        }
        if (score >= 64 && score <= 80)
        {
            color.ChangeColorAtThirtyFivePoints();
            
        }
        if (score >= 81 && score <= 99)
        {
            color.ChangeColorAtTwentyFivePoints();
        }
         

    }

    public void addScore()
    {
        score++;
        UpdateHighScore();
        scoreText.text = score.ToString();

        gameOverScoreText.text = score.ToString();
        
    }

    public void UpdateHighScore()
    {
        if(score > highScore)
        {
            highScore = score;

            highScoreText.text = highScore.ToString();

            PlayerPrefs.SetInt("HighScore", highScore);
            source.clip = button;
            source.Play();
        }
       

    }

    public void ResetScore()
    {
        added = false;
        added1 = false;
        added2 = false;
        added3 = false;
        added4 = false;
        added5 = false;
        added6 = false;
        added7 = false;
        added8 = false;
        added9 = false;
        score = 0;
        scoreText.text = score.ToString();
        gameOverScoreText.text = score.ToString();

    }



}

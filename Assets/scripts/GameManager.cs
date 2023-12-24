using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
  

    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text highscoreText;

    private int score;
    private void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
        highscoreText.text = " En Yüksek Skor:" + PlayerPrefs.GetInt("highScore");
    }
    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
        if (score > PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", score);

        }
        highscoreText.text = "Skor:" + PlayerPrefs.GetInt("highScore");

    }

    public void RestartGame()
    {

        SceneManager.LoadScene(0);




    }












}


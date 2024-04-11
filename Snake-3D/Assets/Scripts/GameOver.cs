using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace SnakeGame
{
public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public ScoreManager scoreManager;

    public void Setup()
    {
        string score = scoreManager.GetScore().ToString();
        UpdateScore(score);
        gameObject.SetActive(true);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void UpdateScore(string score)
    {
        scoreText.text = "GAME OVER" + "\nScore: " + score;
    }

    void Update() {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            RestartGame();
        }
        
    }
}}
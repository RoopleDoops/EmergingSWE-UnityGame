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
    public void Setup()
    {
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

    void Update() {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            RestartGame();
        }
        
    }
}}
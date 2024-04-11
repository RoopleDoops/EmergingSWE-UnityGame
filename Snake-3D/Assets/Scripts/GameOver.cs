using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace SnakeGame
{
    public class GameOver : MonoBehaviour
    {
        bool gameOverScreen;

        public bool Setup()
        {
            gameObject.SetActive(true);
            gameOverScreen = true;

            return gameOverScreen;
        }

        public void MainMenu()
        {
            SceneManager.LoadScene(1);
        }

        public void RestartGame()
        {
            SceneManager.LoadScene(0);
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                RestartGame();
            }
        }
    }
}

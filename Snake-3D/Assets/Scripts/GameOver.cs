using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace SnakeGame
{
    public class GameOver : MonoBehaviour
    {
        public void EndGame()
        {
            SceneManager.LoadScene(1);
        }

        public void RestartGame()
        {
            SceneManager.LoadScene(0);
        }
    }
}

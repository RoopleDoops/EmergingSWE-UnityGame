using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public static TextMeshProUGUI hiScoreText;
    public static int hiScoreCount = 0;

    public static void EndGame()
    {
        SceneManager.LoadScene(1);

        hiScoreCount = PlayerPrefs.GetInt("hiscore", 0);
        hiScoreText.text = "Hi-Score:\n" + hiScoreCount.ToString(); // Display hi score
    }

    public static void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    void Update() {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            RestartGame();
        }
        
    }
}
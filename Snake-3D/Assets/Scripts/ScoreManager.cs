using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text hiScoreText;
    public static int scroeCount;
    public static int hiScroeCount;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            hiScroeCount = PlayerPrefs.GetInt("HiScore");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Update hi-score
        if(scroeCount > hiScroeCount)
        {
            hiScroeCount = scroeCount;
            PlayerPrefs.SetInt("HiScore", hiScroeCount);
        }

        scoreText.text = "Score: " + Mathf.Round(scroeCount);
        hiScoreText.text = "Hi-Score: " + Mathf.Round(hiScroeCount);
    }
}

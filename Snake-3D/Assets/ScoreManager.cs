using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI hiScoreText;

    int scoreCount = 0;
    int hiScoreCount = 0;

    public static ScoreManager instance;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score:\n" + scoreCount.ToString(); // Display score
        hiScoreText.text = "Hi-Score:\n" + hiScoreCount.ToString(); // Display hi score
    }

    // Update is called once per frame
    public void AddPoints()
    {
        // Update hi-score
        scoreCount += 10;
        scoreText.text = "Hi-Score:\n" + scoreCount.ToString();

        if (hiScoreCount < scoreCount)
        {
            PlayerPrefs.SetInt("HiScore", hiScoreCount);
        }
    }
}

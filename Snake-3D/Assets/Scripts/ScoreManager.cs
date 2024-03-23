using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
namespace SnakeGame
{
    public class ScoreManager : MonoBehaviour
    {
        public TextMeshProUGUI scoreText;
        public TextMeshProUGUI hiScoreText;

        public int scoreCount = 0;
        public int hiScoreCount = 0;

        public GameObject playerUiPrefab;
        public static ScoreManager instance;

        private void Awake()
        {
            instance = this;
        }

        // Start is called before the first frame update
        void Start()
        {
            instance = playerUiPrefab.GetComponent<ScoreManager>();

            // Display saved hi-score
            hiScoreCount = PlayerPrefs.GetInt("hiscore", 0);

            scoreText.text = "Score:\n" + scoreCount.ToString(); // Display score
            hiScoreText.text = "Hi-Score:\n" + hiScoreCount.ToString(); // Display hi score
        }

        // Update is called once per frame
        public void AddPoints()
        {
            scoreCount += 10;
            scoreText.text = "Score:\n" + scoreCount.ToString();

            // Save hi-score
            if (hiScoreCount < scoreCount)
                PlayerPrefs.SetInt("hiscore", scoreCount);
        }

        public void AddPointsForTest()
        {
            scoreCount += 10;
        }

        public void RestartForTest()
        {
            scoreCount -= 10;

        }
    }
}
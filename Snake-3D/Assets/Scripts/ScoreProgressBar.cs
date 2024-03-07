using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreProgressBar : MonoBehaviour
{
    [Header("UI references: ")]
    [SerializeField] private Image uiFillImage;
    [SerializeField] private Text uiStartText;
    [SerializeField] private Text uiEndText;

    [Header("Player and Endline references: ")]
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Transform endLineTransform;

    private Vector3 endLinePosition;
    private float fullDistance;

    // Start is called before the first frame update
    void Start()
    {
        endLinePosition = endLineTransform.position;
        fullDistance = GetDistance();
    }

    public void SetLevelTexts(int level)
    {
        uiStartText.text = level.ToString();
        uiEndText.text = (level + 1).ToString();
    }

   private float GetDistance()
    {
        return Vector3.Distance(playerTransform.position, endLinePosition);
    }

    private void UpdateProgressFill(float value)
    {
        uiFillImage.fillAmount = value;
    }

    private void Update()
    {
        float newDistance = GetDistance();
        float progressValue = Mathf.InverseLerp(fullDistance, 0f, newDistance);

        UpdateProgressFill(progressValue);
    }
}

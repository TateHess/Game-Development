using UnityEngine;
using TMPro; // Include the UI text mesh Namespace

public class ScoreManager : MonoBehaviour
{
    public int score; //Keep track of the score
    public TextMeshProUGUI scoreText; //Reference Text UI Objects to update

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScoreText();
    }

    public void IncreaseScoreText(int amount)
    {
        score += amount; //Increase score by amount
        UpdateScoreText(); //Update score UI text
    }

    public void DecreaseScoreText(int amount)
    {
        score -= amount; //Increase score by amount
        UpdateScoreText(); //Update score UI text
    }
    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}

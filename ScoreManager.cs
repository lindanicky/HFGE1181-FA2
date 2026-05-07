using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       UpdateScore();       
    }

    // Update is called once per frame
    public void AddScore(int amount)
    {
        score += amount;
        UpdateScore();
    }
     void UpdateScore()
     {
        scoreText.text = "Score: " + score;
     }

     public void ResetScore()
     {
        score = 0;
        UpdateScore();
     }
}

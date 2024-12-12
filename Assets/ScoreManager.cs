using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; } // 单例实例
    public int score = 0;
    public bool isGameOver = false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this; // 设置单例
        }
        else
        {
            Destroy(gameObject); // 防止重复实例
        }
    }

    public void AddScore(int points)
    {
        if (!isGameOver)
        {
            score += points;
            Debug.Log("Score: " + score);
        }
    }

    public void ResetScore()
    {
        score = 0;
        Debug.Log("分数已清零！");
    }

    public void GameOver()
    {
        isGameOver = true;
        ResetScore();
    }
}

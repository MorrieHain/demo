using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; } // ����ʵ��
    public int score = 0;
    public bool isGameOver = false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this; // ���õ���
        }
        else
        {
            Destroy(gameObject); // ��ֹ�ظ�ʵ��
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
        Debug.Log("���������㣡");
    }

    public void GameOver()
    {
        isGameOver = true;
        ResetScore();
    }
}

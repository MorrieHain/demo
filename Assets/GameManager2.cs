using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    private ScoreManager scoreManager;

    void Start()
    {
        // ��ȡ ScoreManager
        scoreManager = FindAnyObjectByType<ScoreManager>();
    }

    void Update()
    {
        // ʾ�������¼��� "G" ��������Ϸ����
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (scoreManager != null)
            {
                scoreManager.GameOver();
                Debug.Log("Game Over!");
            }
        }
    }
}

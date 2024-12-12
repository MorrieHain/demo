using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    private ScoreManager scoreManager;

    void Start()
    {
        // 获取 ScoreManager
        scoreManager = FindAnyObjectByType<ScoreManager>();
    }

    void Update()
    {
        // 示例：按下键盘 "G" 键触发游戏结束
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

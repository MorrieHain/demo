using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public string gameOverScene = "GameOverScene"; // 游戏结束后加载的场景名称
    public bool restartCurrentScene = false;       // 是否重启当前场景

    void OnCollisionEnter2D(Collision2D collision)
    {
        // 当玩家发生碰撞时触发
        Debug.Log("Player collided with: " + collision.gameObject.name);

        // 检查是否为特定类型的碰撞对象
        if (collision.gameObject.CompareTag("Enemy")) // Obstacle 为障碍物的 Tag
        {
            EndGame();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // 如果使用触发器检测
        if (collision.gameObject.CompareTag("Enemy"))
        {
            EndGame();
        }
    }

    void EndGame()
    {
        Debug.Log("Game Over!");

        if (restartCurrentScene)
        {
            // 重新加载当前场景
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            // 加载游戏结束场景
            SceneManager.LoadScene(gameOverScene);
        }
    }
}

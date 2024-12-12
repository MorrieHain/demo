using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public string gameOverScene = "GameOverScene"; // ��Ϸ��������صĳ�������
    public bool restartCurrentScene = false;       // �Ƿ�������ǰ����

    void OnCollisionEnter2D(Collision2D collision)
    {
        // ����ҷ�����ײʱ����
        Debug.Log("Player collided with: " + collision.gameObject.name);

        // ����Ƿ�Ϊ�ض����͵���ײ����
        if (collision.gameObject.CompareTag("Enemy")) // Obstacle Ϊ�ϰ���� Tag
        {
            EndGame();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // ���ʹ�ô��������
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
            // ���¼��ص�ǰ����
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            // ������Ϸ��������
            SceneManager.LoadScene(gameOverScene);
        }
    }
}

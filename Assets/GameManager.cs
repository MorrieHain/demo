using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject startButton; // ���ÿ�ʼ��ť
    private bool isGameStarted = false; // ��Ϸ�Ƿ��Ѿ���ʼ

    void Start()
    {
        // ��ͣ��Ϸ
        Time.timeScale = 0; // ʱ��ֹͣ
        isGameStarted = false;

        // ��ʾ��ʼ��ť
        if (startButton != null)
        {
            startButton.SetActive(true);
        }
    }

    // �����ʼ��ťʱ����
    public void StartGame()
    {
        // ��ʼ��Ϸ
        Time.timeScale = 1; // �ָ�ʱ��
        isGameStarted = true;

        // ���ذ�ť
        if (startButton != null)
        {
            startButton.SetActive(false);
        }
    }
}

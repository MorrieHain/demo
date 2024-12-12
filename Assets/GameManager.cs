using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject startButton; // 引用开始按钮
    private bool isGameStarted = false; // 游戏是否已经开始

    void Start()
    {
        // 暂停游戏
        Time.timeScale = 0; // 时间停止
        isGameStarted = false;

        // 显示开始按钮
        if (startButton != null)
        {
            startButton.SetActive(true);
        }
    }

    // 点击开始按钮时调用
    public void StartGame()
    {
        // 开始游戏
        Time.timeScale = 1; // 恢复时间
        isGameStarted = true;

        // 隐藏按钮
        if (startButton != null)
        {
            startButton.SetActive(false);
        }
    }
}

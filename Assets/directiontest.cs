using UnityEngine;

public class directiontest : MonoBehaviour
{
    public float rotationOffset = 90f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
}

    // Update is called once per frame
    void Update()
    {
        // 获取鼠标在屏幕上的位置
        Vector3 mousePosition = Input.mousePosition;

        // 将鼠标位置从屏幕空间转换到世界空间
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // 计算目标方向
        Vector2 direction = (Vector2)(mousePosition - transform.position);

        // 计算旋转角度（弧度转角度）
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // 应用旋转（绕 Z 轴旋转）
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - rotationOffset));
    }
}


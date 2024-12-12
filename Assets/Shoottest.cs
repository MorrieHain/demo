using UnityEngine;

public class Shoottest : MonoBehaviour
{
    public GameObject bulletPrefab; // 子弹的预制体
    public Transform Player_0;     // 发射子弹的起点
    public float bulletSpeed = 10f; // 子弹速度

    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = bulletPrefab.GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)
        {
            spriteRenderer.enabled = false; // 隐藏母体
        }
    }

    void Update()
    {
        // 检测鼠标左键点击
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // 创建子弹
        // 修正子弹的初始旋转，使其向左偏移 90 度
        Quaternion correctedRotation = Player_0.rotation * Quaternion.Euler(0, 0, 90);

        // 创建子弹并应用修正后的旋转
        GameObject bullet = Instantiate(bulletPrefab, Player_0.position, correctedRotation);

        SpriteRenderer bulletRenderer = bullet.GetComponent<SpriteRenderer>();
        if (bulletRenderer != null)
        {
            bulletRenderer.enabled = true; // 显示克隆体
        }

        // 获取子弹的 Rigidbody2D
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.linearVelocity = bullet.transform.right * 10;
        }
        bullet.AddComponent<Dis2>();
    }
}

using UnityEngine;

public class Shoottest : MonoBehaviour
{
    public GameObject bulletPrefab; // �ӵ���Ԥ����
    public Transform Player_0;     // �����ӵ������
    public float bulletSpeed = 10f; // �ӵ��ٶ�

    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = bulletPrefab.GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)
        {
            spriteRenderer.enabled = false; // ����ĸ��
        }
    }

    void Update()
    {
        // ������������
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // �����ӵ�
        // �����ӵ��ĳ�ʼ��ת��ʹ������ƫ�� 90 ��
        Quaternion correctedRotation = Player_0.rotation * Quaternion.Euler(0, 0, 90);

        // �����ӵ���Ӧ�����������ת
        GameObject bullet = Instantiate(bulletPrefab, Player_0.position, correctedRotation);

        SpriteRenderer bulletRenderer = bullet.GetComponent<SpriteRenderer>();
        if (bulletRenderer != null)
        {
            bulletRenderer.enabled = true; // ��ʾ��¡��
        }

        // ��ȡ�ӵ��� Rigidbody2D
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.linearVelocity = bullet.transform.right * 10;
        }
        bullet.AddComponent<Dis2>();
    }
}

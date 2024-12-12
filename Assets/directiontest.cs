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
        // ��ȡ�������Ļ�ϵ�λ��
        Vector3 mousePosition = Input.mousePosition;

        // �����λ�ô���Ļ�ռ�ת��������ռ�
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // ����Ŀ�귽��
        Vector2 direction = (Vector2)(mousePosition - transform.position);

        // ������ת�Ƕȣ�����ת�Ƕȣ�
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Ӧ����ת���� Z ����ת��
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - rotationOffset));
    }
}


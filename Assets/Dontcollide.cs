using UnityEngine;

public class Dontcollide : MonoBehaviour
{
    void Awake()
    {
        // ��ȡ Bullet Layer ������
        int bulletLayer = LayerMask.NameToLayer("bullet");

        // �����ӵ����ӵ�֮�����ײ
        Physics2D.IgnoreLayerCollision(bulletLayer, bulletLayer, true);
    }
}

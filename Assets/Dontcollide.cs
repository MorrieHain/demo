using UnityEngine;

public class Dontcollide : MonoBehaviour
{
    void Awake()
    {
        // 获取 Bullet Layer 的索引
        int bulletLayer = LayerMask.NameToLayer("bullet");

        // 禁用子弹与子弹之间的碰撞
        Physics2D.IgnoreLayerCollision(bulletLayer, bulletLayer, true);
    }
}

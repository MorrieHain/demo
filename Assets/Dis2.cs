using UnityEngine;

public class Dis2 : MonoBehaviour
{
    public float lifeTime = 5f;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        Destroy(gameObject);
    }
}


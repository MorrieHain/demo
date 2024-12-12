using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int pointsPerHit = 100;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (ScoreManager.Instance != null)
            {
                ScoreManager.Instance.AddScore(pointsPerHit);
            }

            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}

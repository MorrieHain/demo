using UnityEngine;

public class Randoms : MonoBehaviour
{
    public GameObject meteorPrefab; 
    public float spawnRate = 2f;    
    public float spawnDistance = 10f; 

    public float meteorSpeed = 5f; 

    private float timer = 0f; 

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnRate)
        {
            SpawnMeteor();
            timer = 0f; 
        }
    }

    void SpawnMeteor()
    {
        Vector2 spawnPosition = GetRandomSpawnPosition();

        GameObject Asteroid_01_0 = Instantiate(meteorPrefab, spawnPosition, Quaternion.identity);

        Vector2 targetPosition = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        Vector2 direction = (targetPosition - spawnPosition).normalized;

        Rigidbody2D rb = Asteroid_01_0.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.linearVelocity = direction * meteorSpeed;
        }
    }

    Vector2 GetRandomSpawnPosition()
    {
        Vector3 screenBottomLeft = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
        Vector3 screenTopRight = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));

        float randomX, randomY;
        int side = Random.Range(0, 4); 

        switch (side)
        {
            case 0: 
                randomX = screenBottomLeft.x - spawnDistance;
                randomY = Random.Range(screenBottomLeft.y, screenTopRight.y);
                break;
            case 1: 
                randomX = screenTopRight.x + spawnDistance;
                randomY = Random.Range(screenBottomLeft.y, screenTopRight.y);
                break;
            case 2: 
                randomX = Random.Range(screenBottomLeft.x, screenTopRight.x);
                randomY = screenTopRight.y + spawnDistance;
                break;
            case 3: 
                randomX = Random.Range(screenBottomLeft.x, screenTopRight.x);
                randomY = screenBottomLeft.y - spawnDistance;
                break;
            default:
                randomX = 0;
                randomY = 0;
                break;
        }

        return new Vector2(randomX, randomY);
    }
}


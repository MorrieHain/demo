using Unity.VisualScripting;
using UnityEngine;

public class controllertest : MonoBehaviour
{
    private Rigidbody2D player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 direction = new Vector2(horizontal, vertical);
        Debug.DrawRay(transform.position, direction, Color.red);
        player.AddForce(direction * 5);
    }
}

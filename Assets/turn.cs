using UnityEngine;

public class turn : MonoBehaviour
{
    private float thrust = 25;

    private float turnSpeed = 10;

    private float turnTorque = 10;

    private Rigidbody2D rigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigidbody.AddForce(transform.forward * thrust);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.AddTorque(turnTorque);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rigidbody.AddTorque(-turnTorque);
        }
    }
}

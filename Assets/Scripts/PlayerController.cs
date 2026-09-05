using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MoveSpeed = 3f;

    Rigidbody2D rigidbody;
    Vector2 Movement;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement.x = Input.GetAxisRaw("Horizontal");
        Movement.y = Input.GetAxisRaw("Vertical");

        Movement = Movement.normalized;
    }

    private void FixedUpdate()
    {
        rigidbody.linearVelocity = Movement * MoveSpeed;
    }
}

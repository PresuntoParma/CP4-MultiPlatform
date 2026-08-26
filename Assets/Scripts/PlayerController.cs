using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float speed;

    private Rigidbody rb;
    private float horizontal;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        Vector3 movement = rb.linearVelocity;
        movement.x = horizontal * speed;
        movement.z = 0;

        rb.linearVelocity = movement;
    }
}

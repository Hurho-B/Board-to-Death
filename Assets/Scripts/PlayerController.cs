using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveForce = 50;
    public float maxSpeed = 10f;
    public float turnSpeed = 5f;

    public float groundCheckDistance = 0.25f;

    bool isGrounded = false;
    bool isMoving = false;

    Rigidbody skateBoardRB;

    void Start()
    {

    }

    void FixedUpdate()
    {

    }
}
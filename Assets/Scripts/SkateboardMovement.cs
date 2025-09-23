using UnityEngine;
using UnityEngine.InputSystem;
public class SkateboardMovement : MonoBehaviour
{
    public float forwardForce = 10f;
    public float torqueForce = 5f;

    public Vector3 linearVelocity;

    public Rigidbody skateboardRB;

    private bool isMoving = false;
    private bool isGrounded = true;

    public void Start()
    {
        skateboardRB.centerOfMass = new Vector3(0, -0.5f, 0);
    }

    public void Update()
    {
        linearVelocity = skateboardRB.linearVelocity;
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            skateboardRB.AddForce(transform.forward * forwardForce, ForceMode.Force);
        }


        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -1, 0) * torqueForce, Space.Self);

        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 1, 0) * torqueForce, Space.Self);

        }

    }
}
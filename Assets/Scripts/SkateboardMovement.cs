using UnityEngine;
using UnityEngine.InputSystem;
public class SkateboardMovement : MonoBehaviour
{
    public float forwardForce = 10f;
    public float torqueForce = 5f;

    public Rigidbody skateboardRB;

    private bool isMoving = false;
    private bool isGrounded = true;


    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            skateboardRB.AddForce(transform.forward * forwardForce, ForceMode.Force);
        }


        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, 1, 0) * torqueForce, Space.Self);

        }

    }
}
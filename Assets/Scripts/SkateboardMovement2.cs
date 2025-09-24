using UnityEngine;

public class SkateboardMovement2 : MonoBehaviour
{
    private bool isMoving = false;
    private bool isGrounded = true;
    private bool noseForward = true;

    public Rigidbody skateBoardRB;
    public Vector3 forcePoint;

    public float force = 9.81f;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        skateBoardRB.AddForce(force * skateBoardRB.mass * Vector3.up);
    }
}

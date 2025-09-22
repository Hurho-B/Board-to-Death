using UnityEngine;
using UnityEngine.InputSystem;

public class TestingInputSystem : MonoBehaviour
{
    public float jumpHeight = 5f;
    public float moveSpeed = 10f;

    public void Movement(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            Debug.Log("Ah " + context.phase);
        }
        
    }

    public void Jump (InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            transform.Translate(Vector3.up * jumpHeight * Time.deltaTime);
            Debug.Log("Jump " + context.phase);
        }
    }
}
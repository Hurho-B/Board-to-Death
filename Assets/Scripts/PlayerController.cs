using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool isMoving = false;

    public int kickoffPower = 5;

    Vector3 kickOff = new Vector3(0, 5, 5);

    Rigidbody rb;


    void Start()
    {
        //You get the Rigidbody component you attach to the GameObject
        rb = GetComponent<Rigidbody>();

        //Initialising the force which is used on GameObject in various ways
        m_NewForce = new Vector3(-5.0f, 1.0f, 0.0f);

        //Initialising floats
        m_ForceX = 0;
        m_ForceY = 0;

        //The forces typed in from the text fields (the ones you can manipulate in Game view)
        m_ForceXString = "0";
        m_ForceYString = "0";

        //The GameObject's starting position and Rigidbody position
        m_StartPos = transform.position;
        m_StartForce = m_Rigidbody.transform.position;
    }

    void Update()
    {


        if (Input.GetKeyDown(KeyCode.W))
        {
            m_Rigidbody.AddForce(kickOff, ForceMode.Impulse);
            Debug.Log("space key was pressed");
        }
    }
}
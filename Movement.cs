using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed = 10.0f;
    public float Sprint = 12.0f;
    public Vector3 Jump;
    public float JumpForce = 2.0f;
    public float Crouch = 5.0f;
    public float WallJumpForce = 2.0f;
    public Vector3 WallJump;
    public bool isGrounded;
    public bool isHittingWall;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Jump = new Vector3(0.0f, 2.0f, 0.0f);
        WallJump = new Vector3(0.0f, 2.0f, 2.0f);
    }

    void OnCollisionStay()
    {
        isGrounded = true;
        isHittingWall = true;
    }

    void OnCollisionExit()
    {
        isGrounded = false;
        isHittingWall = false;
    }

    // Update is called once per frame
    void Update()
    {
        //movement
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * Speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W) && (Input.GetKey(KeyCode.R)))
        {
            transform.position += Vector3.forward * Sprint * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A) && (Input.GetKey(KeyCode.R)))
        {
            transform.position += Vector3.forward * Sprint * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * Speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S) && (Input.GetKey(KeyCode.R)))
        {
            transform.position += Vector3.back * Sprint * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D) && (Input.GetKey(KeyCode.R)))
        {
            transform.position += Vector3.right * Sprint * Time.deltaTime;
        }

        //Jump

        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Jump * JumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

        //crouch 

        if (Input.GetKey(KeyCode.LeftControl))
        {
            transform.position += Vector3.forward * Crouch * Time.deltaTime;
        }

        //WallJump

        if (Input.GetKey(KeyCode.Space) && isGrounded && isHittingWall)
        {
            rb.AddForce(WallJump * WallJumpForce, ForceMode.Impulse);
            isGrounded = false;
            isHittingWall = false;
        }
    }
} 

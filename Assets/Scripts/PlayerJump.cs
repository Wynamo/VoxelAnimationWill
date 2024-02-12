using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    Rigidbody rb;
    public float jumpForce = 10f;
    public bool isGrounded;
    public float gravity = -9.81f;
    public float distance = 10f;
    //public AudioSource audioSource;
    //public AudioClip jumpClip;
    //public Vector3 lastGroundedPosition;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
 
        // Gets input and calls jump method
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        CheckGround();
    }

    private void CheckGround()
    {
        Debug.DrawRay(transform.position, Vector3.down * distance, Color.red);
        if (Physics.Raycast((transform.position) + Vector3.up * 3f, Vector3.down * distance, out RaycastHit hit, distance))
        {
            isGrounded = true;
            //lastGroundedPosition = transform.position;

        }
        else
        {
            //Debug.Log("poopy no jumpy jumpy");
            isGrounded = false;
        }
    }

    private void Jump()
    {
        // Adds force to the player rigidbody to jump
        if (isGrounded)
        {
            //Debug.Log("poopy jumpy jumpy");
            //audioSource.PlayOneShot(jumpClip);
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }
}
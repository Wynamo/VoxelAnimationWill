using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsJump : MonoBehaviour
{
    public Rigidbody rb;
    public float gravityScale = 5; 
    private void FixedUpdate()
    {
        rb.AddForce(Physics.gravity * (gravityScale - 1) * rb.mass);
    }
    [SerializeField] float jumpforce = 10;

   
   private void Start()
    {
        rb = GetComponent<Rigidbody>();   
    }

   
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
        }
        
    }
}

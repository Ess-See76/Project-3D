using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // stores Rigidbody as variable
    Rigidbody rb;

    // stores movement speed as variable
    [SerializeField] float moveSpeed = 6f;
    [SerializeField] float jumpForce = 5f;

    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask ground;

    // Start is called before the first frame update
    void Start()
    {
        // Grabs rigidbody from player to control movement
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Grabs input of horizontal & vertical and stores in variable
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Controls horizontal and vertical movement
        rb.velocity = new Vector3(horizontalInput * moveSpeed, rb.velocity.y, verticalInput * moveSpeed);

        // Jump
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        }
    }

    // Grounded method
    bool IsGrounded()
    {
        return Physics.CheckSphere(groundCheck.position, .1f, ground);
    }
    
}

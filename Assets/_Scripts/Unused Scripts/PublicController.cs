using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicController : MonoBehaviour
{
    public CharacterController characterController;
    [Header("Gravity & Jumping")]
    public float stickToGroundForce = 10;
    public float gravity = 10;
    public float jumpForce = 10;
    private float verticalVelocity;

    [Header("Ground Check")]
    public Transform groundCheck;
    public LayerMask groundLayers;
    public float groundCheckRadius;

    private bool grounded;

    void FixedUpdate()
    {
        grounded = Physics.CheckSphere(groundCheck.position, groundCheckRadius, groundLayers);
    }

    private void Move()
    {
        if (grounded && verticalVelocity <= 0) verticalVelocity = -stickToGroundForce * Time.deltaTime;
        else verticalVelocity -= gravity * Time.deltaTime;

        Vector3 verticalMovement = transform.up * verticalVelocity;
        characterController.Move(verticalMovement * Time.deltaTime);
    }

    void Update()
    {
        Move();
    }

    public void Jump()
    {
        if (grounded) verticalVelocity = jumpForce;
    }

}

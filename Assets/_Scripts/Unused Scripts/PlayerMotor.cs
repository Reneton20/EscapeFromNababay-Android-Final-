using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    public Rigidbody rb;
    float moveSpeed = 5;
    float gravity = 1;
    public float jumpspeed = 80;

    Vector3 moveDirection;
    CharacterController controller;

    public void Start()
    {
        controller = GetComponent<CharacterController>();
    }

   public void Update()
    {
        Move();

    }

   public void Move()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        if (controller.isGrounded)
        {
            moveDirection = new Vector3(moveX, 0, moveZ);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= moveSpeed;

            if (Input.GetKeyDown (KeyCode.Space))
            {
                moveDirection.y += jumpspeed;
            }
        }

        moveDirection.y -= gravity;
        controller.Move(moveDirection * Time.deltaTime);
    }

    public void jumpbutton()
    {
        controller = GetComponent<CharacterController>();
        rb.velocity = Vector3.right * jumpspeed;
    }
}

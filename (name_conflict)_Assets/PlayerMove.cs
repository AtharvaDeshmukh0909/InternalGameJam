using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 [RequireComponent(typeof(CharacterController))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField] private string horizontalInputName = "Horizontal";
    [SerializeField] private string verticalInputName = "Vertical";

    [SerializeField] private float movementSpeed = 100f;

    public CharacterController charController;


    

    private void Update()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        float vertInput = Input.GetAxis(verticalInputName) * movementSpeed;     //CharacterController.SimpleMove() applies deltaTime
        float horizInput = Input.GetAxis(horizontalInputName) * movementSpeed;

        Vector3 forwardMovement = transform.forward * vertInput;
        Vector3 rightMovement = transform.right * horizInput;

        //simple move applies delta time automatically
        charController.SimpleMove(forwardMovement + rightMovement);
    }
}
// public float walkSpeed = 6.0f;
// public float jumpSpeed = 8.0f;
// public float runSpeed = 8.0f;
// public float gravity = 20.0f;

// private Vector3 moveDirection = Vector3.zero;
// private CharacterController controller;

// void Start()
// {
//     controller = GetComponent<CharacterController>();
// }

// void Update()
// {
//     if (controller.isGrounded)
//     {
//         moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
//         moveDirection = transform.TransformDirection(moveDirection);
//         moveDirection *= walkSpeed;
//         if (Input.GetButton("Jump"))
//             moveDirection.y = jumpSpeed;
//     }
//     moveDirection.y -= gravity * Time.deltaTime;
//     controller.Move(moveDirection * Time.deltaTime);
// }

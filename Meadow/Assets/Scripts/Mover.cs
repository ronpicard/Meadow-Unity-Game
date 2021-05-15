
using UnityEngine;

public class Mover : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    public float gravity = -9.81f;
    public Transform groundCheck;
    Vector3 velocity;
    bool isGrounded;
    public LayerMask groundMask;
    public float groundDistance = 0.4f;


    // Update is called once per frame
    void Update()
    {
        /*
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            //small number to sorce down
            velocity.y = 0f;
        }
        */

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        
        
        if (Input.GetKeyDown("space"))
        {
            velocity.y = 5;
        }
        
    }
}

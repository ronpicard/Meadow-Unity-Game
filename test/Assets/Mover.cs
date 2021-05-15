
using UnityEngine;

public class Mover : MonoBehaviour
{
    public Rigidbody rigidBody;

    public float forwardForce;
    public float leftForce;
    public float rightForce;
    public float backwardForce;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            //Apply a force to this Rigidbody in direction of this GameObjects up axis
            rigidBody.AddForce(transform.forward * forwardForce);
        }
        if (Input.GetKey("a"))
        {
            //Apply a force to this Rigidbody in direction of this GameObjects up axis
            rigidBody.AddForce(leftForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            //Apply a force to this Rigidbody in direction of this GameObjects up axis
            rigidBody.AddForce(rightForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("s"))
        {
            //Apply a force to this Rigidbody in direction of this GameObjects up axis
            rigidBody.AddForce(backwardForce * Time.deltaTime, 0, 0);
        }
        
    }
}

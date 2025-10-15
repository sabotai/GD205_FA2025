using UnityEngine;

public class SubMove : MonoBehaviour
{
    //Rigidbody allows for independent physics movement with the physics engine
    Rigidbody myRb; //create a new local Rigidbody called myRb
    //public Rigidbody publicRb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //assign our rigidbody to be the component of the type rigidbody
        //attached to the same gameobject as our script
        myRb = GetComponent<Rigidbody>();
    }

    //We have to use FixedUpdate to make sure the physics forced aren't linked
    //to our framerate. We would hate for the movement to slow or speed up according to FPS.
    void FixedUpdate()
    {
        //here we use GetKey because we want to allow continual application like a gas pedal
        //to simulate an analog input
        if (Input.GetKey("w"))
        {
            myRb.AddForce(0f, 0f, 1f); //add force to our rigidbody in this direction
        }

        if (Input.GetKey("s"))
        {
            myRb.AddForce(0f, 0f, -1f); //add force to our rigidbody in this direction
        }

        if (Input.GetKey("a"))
        {
            myRb.AddForce(-1f, 0f, 0f); //add force to our rigidbody in this direction
        }

        if (Input.GetKey("d"))
        {
            myRb.AddForce(1f, 0f, 0f); //add force to our rigidbody in this direction
        }

        if (Input.GetKey("q"))
        {
            myRb.AddForce(0f, 1f, 0f); //add force to our rigidbody in this direction
        }

        if (Input.GetKey("e"))
        {
            myRb.AddForce(0f, -1f, 0f); //add force to our rigidbody in this direction
        }
    }
}

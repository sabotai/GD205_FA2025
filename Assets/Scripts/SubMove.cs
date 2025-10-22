using UnityEngine;

public class SubMove : MonoBehaviour
{
    //Rigidbody allows for independent physics movement with the physics engine
    Rigidbody myRb; //create a new local Rigidbody called myRb
    //public Rigidbody publicRb;
    public AudioClip boomClip;
   
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
            myRb.AddForce(0f, -1f, 0f); //add force to our rigidbody in this direction
        }

        if (Input.GetKey("e"))
        {
            myRb.AddForce(0f, 1f, 0f); //add force to our rigidbody in this direction
        }

        //create a brake using the spacebar
        if (Input.GetKey("space")){
            myRb.linearVelocity *= 0.99f; //decrease the velocity by 1% each loop
        }
    }
    //this function is called whenever this gameobject collides with another one
    //at least one of the objects must have a rigidbody
    void OnCollisionEnter(Collision colReport) //it creates a new Collision object with the info about the collision, similar to the police report when jeremy hit yeyzer
    {
        Debug.Log("collision you died :)"); //a message in the console showing that this is working
        
        //use getcomponent to access the audiosource attached to the same gameobject
        //then access the playoneshot method, which will play an audioclip from the audiosource one time
        //the first parameter is which audioclip
        //the second is the volume percentage represented by a decimal
        GetComponent<AudioSource>().PlayOneShot(boomClip, .95f);
    }
}

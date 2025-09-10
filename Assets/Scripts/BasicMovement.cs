using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public Transform hazard;
    Vector3 startPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Check if the GetKeyDown method of the Input class returns true for the "s" key
       if (Input.GetKeyDown("s")) {
         transform.position += new Vector3(-1f, 0f, 0f);  //take the position of the transform this script is attached to and move it by the amount on the right
       }

       //do the same thing for the other directions
        if (Input.GetKeyDown("a"))
        {
            transform.position += new Vector3(0f, 0f, 1f);
        }
        if (Input.GetKeyDown("d"))
        {
            //big womp
            transform.position += new Vector3(0f, 0f, -1f);
        }
        if (Input.GetKeyDown("w"))
        {
            transform.position += new Vector3(1f, 0f, 0f);
        }
        if (Input.GetKeyDown("e"))
        {
            transform.position += new Vector3(0f, 1f, 0f);
        }
        if (Input.GetKeyDown("q"))
        {
            transform.position += new Vector3(0f, -1f, 0f);
        }

        //check if our player's position (this transform) is the same as the hazard
        if (transform.position == hazard.position)
        {

            //...then reset the player's position to the startPos we assigned in Start()
            transform.position = startPos;
        }
    }
}

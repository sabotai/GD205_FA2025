using UnityEngine;

public class BasicMovementAlt : MonoBehaviour
{
    public Transform hazard;
    public Transform[] walls;
    public AudioSource player;
    Vector3 startPos, oldPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //This version of the script is based on moving the player back if they entered a wall instead
        //of preventing them from entering a wall. This keeps it simpler and has the same effect.

        oldPos = transform.position; //store our original position in case we accidentally move into a wall
        
        //Check if the GetKeyDown method of the Input class returns true for the "s" key
        if (Input.GetKeyDown("s")) //if this key is newly pressed
        {
            transform.position = transform.position + new Vector3(-1f, 0f, 0f); //store our hypothetical position in newPos
        }

        //do the same thing for the other directions
        if (Input.GetKeyDown("a")) //if this key is newly pressed
        {
            transform.position += new Vector3(0f, 0f, 1f);//store our hypothetical position in newPos
        }
        if (Input.GetKeyDown("d")) //if this key is newly pressed
        {
            transform.position += new Vector3(0f, 0f, -1f);//store our hypothetical position in newPos
        }
        if (Input.GetKeyDown("w")) //if this key is newly pressed
        {
            transform.position += new Vector3(1f, 0f, 0f);//store our hypothetical position in newPos
        }

        //We will use a loop to check each item in the array
        for (int i = 0; i < walls.Length; i++)
        {
            if (transform.position == walls[i].position) //check if we are in the same position as each wall
            {
                transform.position = oldPos; //move back to our old position if we had entered a wall
            }
        }



        //check if our player's position (this transform) is the same as the hazard
        if (transform.position == hazard.position)
        {
            player.Play();
            //...then reset the player's position to the startPos we assigned in Start()
            transform.position = startPos;
        }
    }
}

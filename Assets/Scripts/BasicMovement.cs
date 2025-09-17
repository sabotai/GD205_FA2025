using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public Transform hazard;
    public Transform wall;
    public Transform[] walls;
    public AudioSource player;
    Vector3 startPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(0f,0f,0f); //create a temporary Vector3 to store a hypothetical position
        bool move = true; //true by default until we know its the same as a wall
        //Check if the GetKeyDown method of the Input class returns true for the "s" key
       if (Input.GetKeyDown("s")) { //if this key is newly pressed
            newPos = transform.position + new Vector3(-1f, 0f, 0f); //store our hypothetical position in newPos
        }

       //do the same thing for the other directions
        if (Input.GetKeyDown("a")) //if this key is newly pressed
        {
            newPos = transform.position + new Vector3(0f, 0f, 1f);//store our hypothetical position in newPos
        }
        if (Input.GetKeyDown("d")) //if this key is newly pressed
        {
            newPos = transform.position + new Vector3(0f, 0f, -1f);//store our hypothetical position in newPos
        }
        if (Input.GetKeyDown("w")) //if this key is newly pressed
        {
            newPos = transform.position + new Vector3(1f, 0f, 0f);//store our hypothetical position in newPos
        }

        //We will use a loop to check each item in the array
        for (int i = 0; i < walls.Length; i++)
        {
            if (newPos == walls[i].position) //if you hit a wall
            {
                move = false; //make move false
            }
        }
        if (move && newPos != Vector3.zero) //if move is still true, meaning you havent hit any walls
        {
            transform.position = newPos;
        }
    //check if our player's position (this transform) is the same as the hazard
    if (transform.position == hazard.position)
        {
            player.Play(); //play the audio source
            //...then reset the player's position to the startPos we assigned in Start()
            transform.position = startPos;
        }
    }
}

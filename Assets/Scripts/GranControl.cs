using UnityEngine;

public class GranControl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //use the SetFloat method to change the "Move" parameter to a default value of 0 as the default state
        GetComponent<Animator>().SetFloat("Move", 0f);
        
        //change the "Jump Attack" parameter to have a value of false by default
        GetComponent<Animator>().SetBool("Jump Attack", false);

        //if the player is pressing the w key currently
        if (Input.GetKey(KeyCode.W))
        {
            //change the "Move" parameter to have a value of 1 when you're pressing w
            GetComponent<Animator>().SetFloat("Move", 1f);

        }
        //if the player presses the space bar down once
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //change the "Jump Attack" parameter to have a value of true when you're pressing space
            GetComponent<Animator>().SetBool("Jump Attack", true);

        }
    }
}

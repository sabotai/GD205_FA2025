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

        //if the player is pressing the w key currently
        if (Input.GetKey(KeyCode.W))
        {
            //change the "Move" parameter to have a value of 1 when you're pressing w
            GetComponent<Animator>().SetFloat("Move", 1f);

        }
    }
}

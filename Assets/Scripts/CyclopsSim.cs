using UnityEngine;

public class CyclopsSim : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //create a new ray object called laser
        //and assign it using the ScreenPointToRay function which takes a position on a camera
        //and turns it into a ray
        //we access the main camera via the main property of Camera and then the input 
        Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        //create a new raycasthit, which will store the information about the hit
        RaycastHit laserImpactReport = new RaycastHit();

        //this will cast the ray and return true if it hits something AND the left mouse button was pressed down
            if (Physics.Raycast(laser, out laserImpactReport) && Input.GetMouseButtonDown(0))
            {
                //optional check if the object has a tag called "boom"
                //if (laserImpactReport.transform.tag == "boom")
                //    {
                        //destroy the gameobject that we hit
                        Destroy(laserImpactReport.transform.gameObject);
                        Debug.Log("you hit something");
                //    }
            }
        


    }
}

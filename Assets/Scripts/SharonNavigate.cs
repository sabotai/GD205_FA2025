using UnityEngine;
using UnityEngine.AI;

public class SharonNavigate : MonoBehaviour
{
    NavMeshAgent sharon; //create a new navmeshagent
    public Transform target; //create a new transform to assign to our target. using transform makes it dynamic
    public float proximityTriggerDist = 5f; //threshold for moving toward the target
    Vector3 homePosition; //a vector3 to store the original position

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { //assign the local NavMeshAgent 
        sharon = GetComponent<NavMeshAgent>();
        homePosition = transform.position; //set the home position based on the initial position
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, target.position) < proximityTriggerDist) {
            //use NavMeshAgent.SetDestination(Vector3) to order the agent to find a path to that destination
            sharon.SetDestination(target.position);
        } else //if the distance is greater than that threshold
        {
            sharon.SetDestination(homePosition); //then go home sharon, youre drunk
        }
    }
}

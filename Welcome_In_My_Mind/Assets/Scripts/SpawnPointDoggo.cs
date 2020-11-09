using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
//using UnityStandardAssets.Characters.ThirdPerson;

//[RequireComponent(typeof(AICharacterControl))]
public class SpawnPointDoggo : MonoBehaviour
{
    /*public GameObject target;
    private NavMeshAgent agent;
    bool IsOnTrigger = false;

    public Transform waypoints;

    private Transform new_destination;
    private Transform[] waypoints_list;

    //public Transform player;
    //public float Walking_speed = 0.5f;
    //public float Running_speed = 1;

    //private bool player_spotted;
    //private RaycastHit hit;



    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GetComponent<GameObject>();
        waypoints_list = waypoints.GetComponentsInChildren<Transform>();

        agent.destination = target.transform.position; //go position target

        //SelectDest(target);
        //agent.speed = Walking_speed; // Delete when timer is implemented
    }

    private void Update(Collider other)
    {
        if (IsOnTrigger) //si tu es dans son collider
        {
            //go waypoints(3)
            SelectDest(other);

        }
        else
        {
            //après ces 3 waypoints
            agent.destination = target.transform.position; //go position target
        }
    }

    void SelectDest(Collider other)
    {
        do
        {
            new_destination = waypoints_list[Random.Range(1, waypoints_list.Length)];
        } while (new_destination.GetComponent<Collider>() == other);

        agent.destination = new_destination;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            IsOnTrigger = true;
            agent.isStopped = true;
            SelectDest(other);
        }
    }*/

    /*if (Physics.Raycast(transform.position, player.position - transform.position, out hit)) 
            {
                if (hit.collider.CompareTag("Player") && (Vector3.Angle(hit.transform.position, transform.TransformDirection(Vector3.forward)) < 45))
                {
                    Debug.DrawRay(transform.position, player.position - transform.position, Color.red);
                    //aiControl.target = player;
                    agent.speed = Running_speed;
                    player_spotted = true;
                }
                else
                {
                    Debug.DrawRay(transform.position, player.position - transform.position, Color.gray);
                    //player_spotted = false;
                    // needs a timer
                }
            }*/
}

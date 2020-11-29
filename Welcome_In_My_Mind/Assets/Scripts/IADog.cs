using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
public class IADog : MonoBehaviour
{
    public GameObject target;

    private NavMeshAgent agent;

    bool IsOnTrigger = false;

    void Start()
    {
        //animator > boolwalk = true;
        agent = GetComponent<NavMeshAgent>();
    }
    void OnTriggerEnter(Collider other) //si il est dans le collider du player
    {
        if (other.CompareTag("Player"))
        {
            IsOnTrigger = true;
            agent.isStopped = true; //reste à 1 metre en standing

            //animator > boolwalk = false; 


            //si en standing + de 3/5 seconde > alors play animation idle assis (s’assoit au bout d’un moment avant de se relever)
        }
    }
    


    // Update is called once per frame
    void Update()
    {
        if( !IsOnTrigger) //si il n'est plus dans le collider du player
        {
            //animator boolwalk = true;
            agent.destination = target.transform.position; //marche jusq'au player
            //animator > marche
        }
    }
}

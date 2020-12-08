using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
public class IADog : MonoBehaviour
{
    public GameObject target;
    public Animator animator;
    //public Bool Walking;
    private NavMeshAgent agent;

    //bool IsOnTrigger = false;

    void Start()
    {
        animator.SetBool("Walking", true);
        agent = GetComponent<NavMeshAgent>();
        agent.destination = target.transform.position;

        // >> marche automatique
    }
    void OnTriggerEnter(Collider other) //si il est dans le collider du player
    {
        if (other.CompareTag("Player"))
        {
            agent.isStopped = true; 
            animator.SetBool("Walking", false);//reste à 1 metre en standing
        }
    }
    
    void OnTriggerExit(Collider other) //si il est dans le collider du player
    {
        if (other.CompareTag("Player"))
        {
            agent.isStopped = false; 
            animator.SetBool("Walking", true);
            agent.destination = target.transform.position;
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = target.transform.position;

    }
}

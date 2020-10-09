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
        agent = GetComponent<NavMeshAgent>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            IsOnTrigger = true;
            agent.isStopped = true;
            //reste à 1 metre en standing
        }
    }
    


    // Update is called once per frame
    void Update()
    {
        if( !IsOnTrigger)
        {
            agent.destination = target.transform.position;
        }
    }
}

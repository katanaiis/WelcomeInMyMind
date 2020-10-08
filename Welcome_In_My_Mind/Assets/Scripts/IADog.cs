using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
public class IADog : MonoBehaviour
{
    public GameObject target;

    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
/*    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //reste à 1 metre en standing
        }
    }*/


    // Update is called once per frame
    void Update()
    {
        agent.destination = target.transform.position;
    }
}

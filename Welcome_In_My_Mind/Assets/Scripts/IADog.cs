using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IADog : MonoBehaviour
{
    public GameObject target;

    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("U LOSE!");
        }
    }


    // Update is called once per frame
    void Update()
    {
        agent.destination = target.transform.position;
    }
}

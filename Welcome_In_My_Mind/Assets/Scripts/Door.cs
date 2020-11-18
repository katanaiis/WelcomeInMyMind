
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    /*si tu entre dans le collider 
    alors tu play anim Open
    quand le player est sorti du collider
    alors tu play anim de fin (ou open en reverse)*/

    /*public Animation doorAnim;
    public float speed;
    public float MaxOpenValue;
    public Transform door;
    public bool opening = false;
    public bool closing = false;
    private float currentvalue = 0;

    // Update is called once per frame
    void Update()
    {
        if (opening) OpenDoor();
        if (closing) CloseDoor();
    }


    void OnTriggerEnter(Collider obj)
    {
        if (obj.transform.name == "Player")
        {
            opening = true;
            closing = false;
        }

    }
    private void OnTriggerExit(Collider obj)
    {
        if (obj.transform.name == "Player")
        {
            opening = false;
            closing = true;
        }
    }

    void OpenDoor()
    {
        float movement = speed * Time.deltaTime;
        currentvalue += movement;
        if (currentvalue <= MaxOpenValue)
        {
            door.position = new Vector3(

                door.position.x,
                door.position.y,
                door.position.z + movement
                );
        }
        else
        {
            opening = false;
        }
    }

    void CloseDoor()
    {
        float movement = speed * Time.deltaTime;
        currentvalue -= movement;
        if (currentvalue >= 0x0)
        {
            door.position = new Vector3(

                door.position.x,
                door.position.y,
                door.position.z - movement
                );
        }
        else
        {
            closing = false;
        }
    }*/

    /*void OnTriggerEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Porte.animation.Play("porte");

        }
    }*/


    /*// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsOnTrigger) // ou othercomparetag player
        {
            //play anim Open
            //play son open door
            
        }
        *//*while () //tant que le player n'est pas sorti du collider
        {
            //attendre
        }*//*
        else
        {
            //alors tu play anim de fin (ou open en reverse)
            //play son open door
        }

    }*/
}

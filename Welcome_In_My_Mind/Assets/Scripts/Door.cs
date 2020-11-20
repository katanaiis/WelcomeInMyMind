
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    /*si tu entre dans le collider 
    alors tu play anim Open
    quand le player est sorti du collider
    alors tu play anim de fin (ou open en reverse)*/


    //public Transform door;
    public Animator porte;

    public AudioSource portesong;

    void Start()
    {
        portesong = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            porte.SetTrigger("open");
            portesong.Play();
        }

    }
    private void OnTriggerExit(Collider other)
    {
     
        if (other.gameObject.tag == "Player")
        {
            porte.SetTrigger("close");
            portesong.Play();
        }
    }

    /*private void OnStateEnter(Animator porte)
    {
        porte.gameObject.GetComponent<AudioSource>().Play();
    }*/


}

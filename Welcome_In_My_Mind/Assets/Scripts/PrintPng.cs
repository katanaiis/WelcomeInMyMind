using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintPng : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnMouseDown ()
    {
        Debug.Log("click sur " + this.gameObject.name); //affiche png sur caméra 
    }
}

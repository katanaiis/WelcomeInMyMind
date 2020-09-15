using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintPng : MonoBehaviour
{
    [SerializeField] private Image customImage;
    // Start is called before the first frame update
    void Start()
    {
        customImage.enabled = false;
    }

    // Update is called once per frame
    void OnMouseDown ()
    {
        Debug.Log("click sur " + this.gameObject.name); //affiche png sur caméra 
        customImage.enabled = true;
    }
}

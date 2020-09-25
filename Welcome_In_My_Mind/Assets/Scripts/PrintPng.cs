﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintPng : MonoBehaviour
{
    public GameObject image;

    //[SerializeField] private Image customImage;


    // Start is called before the first frame update

    // Update is called once per frame
    void OnMouseDown ()
    {
        Debug.Log("click sur " + this.gameObject.name); //affiche png sur caméra 
        if (image.activeSelf)
        {
            image.SetActive(false);
        }
        else
        {
            image.SetActive(true);
        }
    }
}

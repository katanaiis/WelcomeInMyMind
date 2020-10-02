using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonQuit : MonoBehaviour
{
    public Canvas canvas;

    void Start()
    {
        canvas = GetComponent<Canvas>();
    }

    void OnMouseDown()
    {
        canvas.GetComponent<Canvas>().enabled = false;
    }
}

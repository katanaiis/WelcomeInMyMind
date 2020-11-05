using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonQuit : MonoBehaviour
{
    public Canvas canvas;
    //public Button button;

    void Start()
    {
        /*if( canvas == null)
        {
            transform.parent.GetComponent<canvas>();
        }*/
        
    }

    public void Quit()
    {
        if (canvas.enabled == true)
        {
            //button.enabled = active;
            canvas.enabled = false;
        }
    }
}

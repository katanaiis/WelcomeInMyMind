using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Play : MonoBehaviour
{

    public UnityEvent onClick;
    //public bool start;
    //public UnityEvent whenAnimation;
    public void OnMouseDown()
    {
        //start = true;
        onClick?.Invoke();
    }


    /*public void PlayWithAnimation()
    {
        whenAnimation.Invoke();
    }*/
}

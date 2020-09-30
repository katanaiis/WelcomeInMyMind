using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public void OnMouseDown()
    {
        Debug.Log("exitgame");
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonQuit : MonoBehaviour
{
    public GameObject canvas;

    // Start is called before the first frame update

    // Update is called once per frame
    void OnMouseDown()
    {
        if (canvas.activeSelf)
        {
            canvas.SetActive(false);
        }
    }
}

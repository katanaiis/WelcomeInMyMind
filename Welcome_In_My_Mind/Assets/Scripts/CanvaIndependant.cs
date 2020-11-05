using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvaIndependant : MonoBehaviour
{
    public Button button;
    public Image image;
    public Canvas canvas;

    private void OnMouseDown()
    {
        /*Button button = button.GetComponent<Button>();
        Canvas canvas = canvas.GetComponent<Canvas>();
        Text text = button.GetComponentInChildren<Text>();*/
        canvas.enabled = true;
        button.enabled = true;
        image.enabled = true;

        if ( canvas.enabled == true)
        {
            canvas.enabled = false;
            button.enabled = false;
            image.enabled = false;
            //text.color = buttonActive;
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonLR : MonoBehaviour
{

    public Sprite[] sprites;
    int index = 0;

    public GameObject buttonNext;
    public GameObject buttonPrevious;
    public Color buttonActive = new Color(0.04f, 0.04f, 0.04f);
    public Color buttonInactive = new Color(0.4f, 0.4f, 0.4f);
    public Image image;

    private void activateButton(bool active, GameObject buttonGo)
    {
        Button button = buttonGo.GetComponent<Button>();
        button.enabled = active;
        Text text = buttonGo.GetComponentInChildren<Text>();
        if (active == true)
        {
            text.color = buttonActive;
        }
        else
        {
            text.color = buttonInactive;
        }

    }

    private void MoveImage(int move)
    {
        index += move;

        if (index < 0)
        {
            index = 0;
            activateButton(false, buttonPrevious);
        }
        else
        {
            activateButton(true, buttonPrevious);
        }

        if (index >= sprites.Length)
        {
            index = sprites.Length - 1;
            activateButton(false, buttonNext);
        }
        else
        {
            activateButton(true, buttonNext);
        }
        image.sprite = sprites[index];
    }

    public void Next()
    {
        MoveImage(1);
    }

    public void Previous()
    {
        MoveImage(-1);
    }

}

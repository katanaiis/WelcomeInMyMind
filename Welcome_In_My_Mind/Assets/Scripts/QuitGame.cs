﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("exitgame");
        //Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
}

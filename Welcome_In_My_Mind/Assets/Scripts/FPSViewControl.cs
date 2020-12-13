﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSViewControl : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move =  transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
    }
}


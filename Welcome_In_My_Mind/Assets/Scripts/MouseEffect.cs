using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class MouseEffect : MonoBehaviour
{
    private SpriteRenderer rend;
    //public Sprite normalCursor;

    public GameObject trailEffect;
    public float timeSpawn = 0.1f;

    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursorPos;

        //Instanciate(clickEffect, transform.position, Quaternion.identity);

        if(timeSpawn <= 0)
        {
            Instantiate(trailEffect, cursorPos, Quaternion.identity);
            timeSpawn = 0.1f;
        }
        else
        {
            timeSpawn -= Time.deltaTime;
        }
    }
}

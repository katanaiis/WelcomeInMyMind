using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScreen : MonoBehaviour
{
    public Image blackScreen;
    public Text quote;
    [Range(0.0f, 1.0f)]
    public float fadespeed = 0.1f;
    //public int secondsBeforeRestart = 3;

    private float blackFade = 2.0f;
    private float quoteFade = 0.0f;
    private bool fadeIn = false;
    private bool fadeOut = false;
    private GameManager gameManager;

    private void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        if (fadeIn)
        {
            if (blackFade < 2.0f)
            {
                blackFade += fadespeed;
            }
            else
            {
                fadeIn = false;
                //StartCoroutine(WaitForRestart(secondsBeforeRestart));

            }
            if (quoteFade < 1.0f)
            {
                quoteFade += fadespeed;
            }
        }
        else if (fadeOut)
        {
            if (blackFade > -0.5f)
            {
                blackFade -= fadespeed;
            }
            else
            {
                fadeOut = false;
            }
            if (quoteFade > 0.0f)
            {
                quoteFade -= fadespeed;
            }

        }
        blackScreen.material.SetFloat("AlphaThr", blackFade);
        quote.color = new Color(0.9f, 0.9f, 0.9f, quoteFade);
    }

    public void FadeOut()
    {
        fadeOut = true;
        fadeIn = false;
    }
    public void FadeIn()
    {
        fadeIn = true;
        fadeOut = false;
    }

    //private IEnumerator WaitForRestart(float seconds)
    //{
        //yield return new WaitForSeconds(seconds);
        //gameManager.Restart();
    //}
}

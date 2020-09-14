using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButterflyLoadScene : MonoBehaviour
{
    public string sceneName;
    //public GameObject butterfly;

    //private Animator animator;
    //private AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void OnMouseDown()
    {
        //AudioSource sound = butterfly.GetComponent<AudioSource>();
        //butterfly.GetComponent<Animation>().Play();
        //sound.Play();

        //wait 3-5 seconde ou la fin de l'anim et du sons
        SceneManager.LoadScene(sceneName);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneVide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        Debug.Log("click sur " + this.gameObject.name); 
        //anim réveil start 
        //SceneManager.LoadScene("Fin", LoadSceneMode.Additive); //start scène vide
    }
}

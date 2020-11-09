using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
//using System.Collections.IEnumerator;

public class Play : MonoBehaviour
{

    public UnityEvent onClick;
    public string sceneName;
    public Animator animator;
    private IEnumerator coroutine;

    /*public void start()
    {
        animation = GetComponent<Animation>();
    }*/

    public void OnMouseDown()
    {
        Debug.Log("debug");
        //start = true;
        onClick?.Invoke();
        animator.SetTrigger("BlinkTrigger");
        //animator.Play();
        

        StartCoroutine(WaitForAnimation(animator));

        
    }

    private IEnumerator WaitForAnimation(Animator animator)
    {
        while (animator)
        {
            yield return new WaitForSeconds(1);
        }
        SceneManager.LoadScene(sceneName);
    }
}


using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{

    public UnityEvent onClick;
    public string sceneName;
    private IEnumerator coroutine;

    public void OnMouseDown()
    {
        //start = true;
        onClick?.Invoke();

        coroutine = Wait();
        StartCoroutine(coroutine);


        SceneManager.LoadScene(sceneName);
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(100000);
    }


    /*public void PlayWithAnimation()
    {
        whenAnimation.Invoke();
    }*/
}

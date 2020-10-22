using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Animator))]
public class PlayAnim : MonoBehaviour
{
    private Animator anim;

    // Update is called once per frame
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void PlayAnimation()
    {
        anim.SetBool("start", true);
    }
}

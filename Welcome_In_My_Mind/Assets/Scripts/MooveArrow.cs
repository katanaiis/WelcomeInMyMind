using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MooveArrow : MonoBehaviour
{
    public float mooveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        mooveSpeed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(mooveSpeed*Input.GetAxis("Horizontal") * Time.deltaTime, 0f, mooveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
    }
}

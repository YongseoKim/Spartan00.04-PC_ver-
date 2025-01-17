using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpartaAnimatorControl : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            anim.SetTrigger("Block");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            anim.SetTrigger("Slash");
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            anim.SetTrigger("Idle");
        }
    }
}

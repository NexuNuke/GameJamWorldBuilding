using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunController : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }


    private float timeCount = 0.0f;
    // Update is called once per frame
    void Update()
    {
        if (ColourController.whiteblack == true)
        {
            animator.SetBool("Down", true);
        }
        else
        {
            animator.SetBool("Down", false);
        }
     }
}

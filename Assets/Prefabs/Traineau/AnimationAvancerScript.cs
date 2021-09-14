using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationAvancerScript : MonoBehaviour
{
    private string Tir2;
    private string Tir1;
    Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        Tir1 = PlayerPrefs.GetString("Tir1");
        Tir2 = PlayerPrefs.GetString("Tir2");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(Tir1) )
        {
            animator.SetBool("tir1", true);
        }
        else
        {
            animator.SetBool("tir1", false);
        }

        if (Input.GetKey(Tir2) )
        {
            animator.SetBool("tir2", true);
        }
        else
        {
            animator.SetBool("tir2", false);
        }
    }
}

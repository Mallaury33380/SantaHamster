using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    private string Avancer;
    private string Reculer;
    private string Gauche;
    private string Droite;

    Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        Avancer = PlayerPrefs.GetString("Avancer");
        Reculer = PlayerPrefs.GetString("Reculer");
        Gauche = PlayerPrefs.GetString("Gauche");
        Droite = PlayerPrefs.GetString("Droite");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(Avancer))
        {
            animator.SetBool("deplacement", true);
        }
        else
        {
            animator.SetBool("deplacement", false);
        }

        if (Input.GetKey(Reculer) || Input.GetKey(Gauche) || Input.GetKey(Droite))
        {
            animator.SetBool("marche", true);
        }
        else
        {
            animator.SetBool("marche", false);
        }
    }
}

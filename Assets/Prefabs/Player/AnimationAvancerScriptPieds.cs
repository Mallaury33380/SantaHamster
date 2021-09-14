using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationAvancerScriptPieds : MonoBehaviour
{
    public AudioSource Clochettes;
    public AudioSource Marche;
    public AudioSource Lancer;

    private string Avancer;
    private string Reculer;
    private string Gauche;
    private string Droite;
    private string Tir1;
    private string Tir2;

    Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        Avancer = PlayerPrefs.GetString("Avancer");
        Reculer = PlayerPrefs.GetString("Reculer");
        Gauche = PlayerPrefs.GetString("Gauche");
        Droite = PlayerPrefs.GetString("Droite");
        Tir1 = PlayerPrefs.GetString("Tir1");
        Tir2 = PlayerPrefs.GetString("Tir2");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(Avancer) || Input.GetKey(Reculer) || Input.GetKey(Gauche)|| Input.GetKey(Droite))
        {
            animator.SetBool("avancer", true);
            if (Clochettes.isPlaying== false)
            {
                Clochettes.Play();
            }
            if (Marche.isPlaying == false)
            {
                Marche.Play();
            }
        }
        else
        {
            animator.SetBool("avancer", false);
        }



        if (Input.GetKey(Tir1) )
        {
            animator.SetBool("tir1", true);
            if (Lancer.isPlaying == false)
            {
                Lancer.Play();
            }
        }
        else
        {
            animator.SetBool("tir1", false);
        }

        if (Input.GetKey(Tir2) )
        {
            animator.SetBool("tir2", true);
            Lancer.Play();
        }
        else
        {
            animator.SetBool("tir2", false);
        }
    }
}

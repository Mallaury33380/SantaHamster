using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enfantReact : MonoBehaviour
{
    public AudioSource joie;
    public AudioSource cris;
    public int scorevalue;



    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "cadeau")
        {
            Animator animator = gameObject.GetComponent<Animator>();
            animator.SetBool("joie", true);
            joie.Play();
            PlayerPrefs.SetFloat("Score", PlayerPrefs.GetFloat("Score") + scorevalue);
        }
        if (other.tag == "Player")
        {
            Animator animator = gameObject.GetComponent<Animator>();
            animator.SetBool("cris", true);
            cris.Play();
            PlayerPrefs.SetFloat("Score", PlayerPrefs.GetFloat("Score") - scorevalue * 3);
            StartCoroutine(LoadDelayed(0.5f));
        }
    }

    IEnumerator LoadDelayed(float tempsEnSecondes = 5f)
    {
        yield return new WaitForSeconds(tempsEnSecondes);
        Destroy(transform.parent.gameObject);
    }

}

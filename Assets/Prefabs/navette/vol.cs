using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vol : MonoBehaviour
{
    public AudioSource Sonvol;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Animator animator = GetComponent<Animator>();
            Sonvol.Play();
            animator.SetBool("vol", true);
            StartCoroutine(LoadDelayed(7f));
        }
    }
    IEnumerator LoadDelayed(float tempsEnSecondes = 5f)
    {
        yield return new WaitForSeconds(tempsEnSecondes);
        Animator animator = gameObject.GetComponent<Animator>();
        Sonvol.Play();
        animator.SetBool("vol", false);
    }
}
